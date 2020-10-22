using Core;
using GameSdk.Attributes;
using PluginSdk.Attributes;
using PluginSdk.Information;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.Json;
using System.Threading.Tasks;

namespace Manager.Generators
{
    public enum PluginType
    {
        Git
    }

    public static class PluginGenerator
    {
        public static async Task Save()
        {
            var plugins = GetPlugins();
            CheckGuid(plugins);

            await Task.WhenAll(SaveGames(plugins), SaveInstallers(plugins)
#if DEBUG
                , SaveLangs(plugins)
#endif
            );
        }

        private static async Task SaveLangs(IEnumerable<Plugin> plugins)
        {
            foreach (LanguageType id in Enum.GetValues(typeof(LanguageType)))
            {
                var entries = plugins.Select(plugin => plugin.GetType())
                    .Select(plugin => new
                    {
                        plugin.GetCustomAttribute<PluginAttribute>().Guid,
                        Lang = plugin.GetCustomAttributes<PluginSdk.Attributes.LanguageAttribute>().FirstOrDefault(lang => lang.Type == id)
                    })
                    .Where(p => !(p.Lang is null))
                    .ToDictionary(key => key.Guid, value => new
                    {
                        name = value.Lang.Name,
                        description = value.Lang.Description
                    });

                await File.WriteAllTextAsync(Path.Join(@"..\illusion-package-manager\src\i18n\languages", Enum.GetName(typeof(LanguageType), id).ToLower(), "plugins.json"), JsonSerializer.Serialize(entries));
            }
        }

        private static async Task SaveGames(IEnumerable<Plugin> plugins)
        {
            var dst = Path.Join(Core.FakeDir, "api", "plugins", "games");
            Directory.CreateDirectory(dst);

            var games = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(a => a.GetTypes())
                .Where(t => t.IsDefined(typeof(GameAttribute)))
                .Select(entry => entry.GetCustomAttribute<GameAttribute>().Guid)
                .ToDictionary(key => key, _ => new List<object>());

            foreach (var plugin in plugins)
            {
                PluginAttribute attribute = plugin.GetType().GetCustomAttribute<PluginAttribute>();

                if (plugin is GitSharedPlugin sharedGit)
                {
                    foreach (var type in sharedGit.Games)
                    {
                        var game = type.GetCustomAttribute<GameAttribute>();
                        games[game.Guid].Add(new
                        {
                            guid = attribute.Guid,
                            dependencies = attribute.Dependencies.Select(t => t.GetCustomAttribute<PluginAttribute>().Guid),
                        });
                    }
                }
                else if (plugin is GitPlugin git)
                {
                    foreach (var entity in git.Entities)
                    {
                        foreach (var type in entity.Games)
                        {
                            var game = type.GetCustomAttribute<GameAttribute>();
                            games[game.Guid].Add(new
                            {
                                guid = attribute.Guid,
                                dependencies = attribute.Dependencies.Select(t => t.GetCustomAttribute<PluginAttribute>().Guid),
                            });
                        }
                    }
                }
            }

            foreach (var (guid, entities) in games)
            {
                await File.WriteAllTextAsync(Path.Join(dst, $"{guid}.json"), JsonSerializer.Serialize(entities));
            }
        }

        private static async Task SaveInstallers(IEnumerable<Plugin> plugins)
        {
            string installersDir = Path.Join(Core.FakeDir, "api", "plugins", "installers");
            Directory.CreateDirectory(installersDir);

            string infosDir = Path.Join(installersDir, "infos");
            Directory.CreateDirectory(infosDir);

            string entitiesDir = Path.Join(installersDir, "entities");
            Directory.CreateDirectory(entitiesDir);

            var games = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(a => a.GetTypes())
                .Where(t => t.IsDefined(typeof(GameAttribute)))
                .Select(entry => entry.GetCustomAttribute<GameAttribute>().Guid);

            foreach (var guid in games)
            {
                Directory.CreateDirectory(Path.Join(entitiesDir, $"{guid}"));
            }

            foreach (Plugin plugin in plugins)
            {
                PluginAttribute attribute = plugin.GetType().GetCustomAttribute<PluginAttribute>();

                string infosPath = Path.Join(infosDir, $"{attribute.Guid}.json");

                var dependencies = attribute.Dependencies.Select(t => t.GetCustomAttribute<PluginAttribute>().Guid);

                if (plugin is GitSharedPlugin sharedGit)
                {
                    foreach (var type in sharedGit.Games)
                    {
                        GameAttribute game = type.GetCustomAttribute<GameAttribute>();

                        string entityPath = Path.Join(entitiesDir, $"{game.Guid}", $"{attribute.Guid}.json");
                        await File.WriteAllTextAsync(entityPath, JsonSerializer.Serialize(new
                        {
                            sharedGit.GitUser,
                            sharedGit.GitRepository,
                            sharedGit.FileMask
                        }));
                    }

                    await File.WriteAllTextAsync(infosPath, JsonSerializer.Serialize(new
                    {
                        Type = PluginType.Git,
                        Dependencies = dependencies,
                    }));
                }
                else if (plugin is GitPlugin git)
                {
                    foreach (var entity in git.Entities)
                    {
                        foreach (var type in entity.Games)
                        {
                            GameAttribute game = type.GetCustomAttribute<GameAttribute>();

                            string entityPath = Path.Join(entitiesDir, $"{game.Guid}", $"{attribute.Guid}.json");
                            await File.WriteAllTextAsync(entityPath, JsonSerializer.Serialize(new
                            {
                                git.GitUser,
                                git.GitRepository,
                                entity.FileMask
                            }));
                        }
                    }

                    await File.WriteAllTextAsync(infosPath, JsonSerializer.Serialize(new
                    {
                        Type = PluginType.Git,
                        Dependencies = dependencies,
                    }));
                }
                else
                {
                    throw new Exception();
                }
            }
        }

        private static void CheckGuid(IEnumerable<Plugin> plugins)
        {
            Dictionary<Guid, Plugin> @using = new Dictionary<Guid, Plugin>();
            foreach (var plugin in plugins)
            {
                PluginAttribute attribute = plugin.GetType().GetCustomAttribute<PluginAttribute>();
                if (@using.TryGetValue(attribute.Guid, out var used))
                {
                    var pluginLangs = plugin.GetType().GetCustomAttributes<PluginSdk.Attributes.LanguageAttribute>();
                    var usedLangs = used.GetType().GetCustomAttributes<PluginSdk.Attributes.LanguageAttribute>();

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

                @using.Add(attribute.Guid, plugin);
            }
        }

        private static IEnumerable<Plugin> GetPlugins() => AppDomain.CurrentDomain
                .GetAssemblies()
                .SelectMany(a => a.GetTypes())
                .Where(t => t.IsDefined(typeof(PluginAttribute)))
                .Select(t => Activator.CreateInstance(t) as Plugin);
    }
}