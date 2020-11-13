using Core;
using GameSdk.Attributes;
using GameSdk.Information;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.Json;
using System.Threading.Tasks;

namespace Manager.Generators
{
    public class GameGenerator
    {
        public static async Task Save()
        {
            var games = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(a => a.GetTypes())
                .Where(t => t.IsDefined(typeof(GameAttribute)))
                .Select(entry => Activator.CreateInstance(entry) as Game);

            CheckGuid(games);

            await Task.WhenAll(SaveGamesEntities(games)
#if DEBUG
                , SaveLangs(games)
#endif
            );
        }

        private static Task SaveGamesEntities(IEnumerable<Game> games)
        {
            var entries = games.Select(game =>
            {
                var attribute = game.GetType().GetCustomAttribute<GameAttribute>();

                return new
                {
                    guid = attribute.Guid,
                    icon = game.Icon,
                    exe = game.Exe,
                    extensions = game.Extensions,
                };
            });

            string dst = Path.Join(Core.FakeDir, "api");
            Directory.CreateDirectory(dst);

            return File.WriteAllTextAsync(Path.Join(dst, "games.json"), JsonSerializer.Serialize(entries));
        }

        private static Task SaveLangs(IEnumerable<Game> games) => Task.WhenAll((Enum.GetValues(typeof(LanguageType)) as LanguageType[])
            .Select(id =>
            {
                var entries = games.Select(game => game.GetType())
                    .Select(plugin => new
                    {
                        plugin.GetCustomAttribute<GameAttribute>().Guid,
                        Lang = plugin.GetCustomAttributes<LanguageAttribute>().FirstOrDefault(lang => lang.Type == id)
                    })
                    .Where(p => !(p.Lang is null))
                    .ToDictionary(key => key.Guid, value => value.Lang.Name);

                var dst = Path.Join(Core.WebDir, "src", "i18n", "languages", Enum.GetName(typeof(LanguageType), id).ToLower());
                Directory.CreateDirectory(dst);

                return File.WriteAllTextAsync(Path.Join(dst, "games.json"), JsonSerializer.Serialize(entries));
            }));

        private static void CheckGuid(IEnumerable<Game> games)
        {
            Dictionary<Guid, Game> @using = new Dictionary<Guid, Game>();
            foreach (var game in games)
            {
                GameAttribute attribute = game.GetType().GetCustomAttribute<GameAttribute>();
                if (@using.TryGetValue(attribute.Guid, out var used))
                {
                    var pluginLangs = game.GetType().GetCustomAttributes<LanguageAttribute>();
                    var usedLangs = used.GetType().GetCustomAttributes<LanguageAttribute>();

                    Console.WriteLine($"Guid {attribute.Guid} in");
                    foreach (var lang in pluginLangs)
                    {
                        Console.WriteLine($"\t{lang.Name}");
                    }

                    Console.WriteLine($"Already used in");
                    foreach (var lang in usedLangs)
                    {
                        Console.WriteLine($"\t{lang.Name}");
                    }

                    Environment.Exit(1);
                }

                @using.Add(attribute.Guid, game);
            }
        }
    }
}