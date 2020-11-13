using Core;
using Manager.Contents.Games;
using Manager.Contents.Plugins.BepInExPlugins;
using PluginSdk.Attributes;
using PluginSdk.Information;
using System;

namespace Manager.Contents.Plugins.IllusionModsPlugins
{
    [Language(LanguageType.English, "TextDumpPlugin", "Dumps untranslated text in to .txt files so that the lines can be used by translators working on the translation projects. Normally only executes under studio on initial load. Versions for localized games run under the main game and require multiple dump stages. Check the console and/or log file for specifics")]
    [Plugin("C2011E96-C9DE-4AA2-AF5C-FE30C8FD5367", typeof(BepInExPlugin))]
    public sealed class TextDumpPlugin : GitPlugin
    {
        public TextDumpPlugin()
        {
            Author = PluginInfo.Author;
            GitUser = "IllusionMods";
            GitRepository = "TranslationTools";
            Entities = new GitEntityPlugin[]
            {
                new GitEntityPlugin()
                {
                    FileMask = @"KK_TextDump\.v.*?\.zip",
                    Games = new Type[] { typeof(KoikatuGame) }
                },
                new GitEntityPlugin()
                {
                    FileMask = @"KKP_TextDump\.v.*?\.zip",
                    Games = new Type[] { typeof(KoikatuSteamGame) }
                },
                new GitEntityPlugin()
                {
                    FileMask = @"HS2_TextDump\.v.*?\.zip",
                    Games = new Type[] { typeof(HoneySelect2Game) }
                },
                new GitEntityPlugin()
                {
                    FileMask = @"AI_TextDump\.v.*?\.zip",
                    Games = new Type[] { typeof(AiShoujoGame) }
                },
                new GitEntityPlugin()
                {
                    FileMask = @"AI_INT_TextDump\.v.*?\.zip",
                    Games = new Type[] { typeof(AiShoujoSteamGame) }
                }
            };
        }
    }
}
