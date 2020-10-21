using Core;
using Manager.Contents.Games;
using PluginSdk.Attributes;
using PluginSdk.Information;
using System;

namespace Manager.Contents.Plugins.DeathWeasel1337Plugins.KK_Plugins
{
    [Language(LanguageType.English, "", "")]
    [Plugin("56C9EAA1-5966-438E-8D6B-82D5246360AB", typeof(BepInExPlugins.BepInExPlugin))]
    public sealed class ClothingUnlockerPlugin : GitPlugin
    {
        public ClothingUnlockerPlugin()
        {
            Author = PluginInfo.Author;
            GitUser = "DeathWeasel1337";
            GitRepository = "KK_Plugins";

            Entities = new GitEntityPlugin[]
            {
                new()
                {
                    FileMask = @"\.v.*?\.zip",
                    Games = new Type[] { typeof(KoikatsuGame) }
                }
            };
        }
    }
}