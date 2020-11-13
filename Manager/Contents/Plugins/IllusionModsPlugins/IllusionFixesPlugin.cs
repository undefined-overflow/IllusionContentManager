using Core;
using Manager.Contents.Games;
using Manager.Contents.Plugins.BepInExPlugins;
using PluginSdk.Attributes;
using PluginSdk.Information;
using System;

namespace Manager.Contents.Plugins.IllusionModsPlugins
{
    [Language(LanguageType.English, "Illusion Fixes", "A collection of fixes for common issues found in Koikatu, Koikatsu Party, EmotionCreators, AI Girl and HoneySelect2")]
    [Plugin("D4A1695A-E8ED-442C-8D00-1BB5ADA31BC9", typeof(BepInExPlugin))]
    public sealed class IllusionFixesPlugin : GitPlugin
    {
        public IllusionFixesPlugin()
        {
            Author = PluginInfo.Author;
            GitUser = "IllusionMods";
            GitRepository = "IllusionFixes";
            Entities = new GitEntityPlugin[]
            {
                new GitEntityPlugin()
                {
                    FileMask = @"IllusionFixes_Koikatsu_.*?\.zip",
                    Games = new Type[] { typeof(KoikatuGame) }
                },
                new GitEntityPlugin()
                {
                    FileMask = @"IllusionFixes_EmotionCreators_.*?\.zip",
                    Games = new Type[] { typeof(EmotionCreatorsGame) }
                },
                new GitEntityPlugin()
                {
                    FileMask = @"IllusionFixes_HoneySelect2_.*?\.zip",
                    Games = new Type[] { typeof(HoneySelect2Game) }
                },
                new GitEntityPlugin()
                {
                    FileMask = @"IllusionFixes_HoneySelect_.*?\.zip",
                    Games = new Type[] { typeof(HoneySelect1Game) }
                },
                new GitEntityPlugin()
                {
                    FileMask = @"IllusionFixes_PlayHome_.*?\.zip",
                    Games = new Type[] { typeof(PlayHomeGame) }
                },
                new GitEntityPlugin()
                {
                    FileMask = @"IllusionFixes_AIGirl_.*?\.zip",
                    Games = new Type[] { typeof(AiShoujoGame) }
                }
            };
        }
    }
}
