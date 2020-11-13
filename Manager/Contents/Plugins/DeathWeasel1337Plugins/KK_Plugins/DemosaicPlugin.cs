using Core;
using Manager.Contents.Games;
using PluginSdk.Attributes;
using PluginSdk.Information;
using System;

namespace Manager.Contents.Plugins.DeathWeasel1337Plugins.KK_Plugins
{
    [Language(LanguageType.English, "", "")]
    [Plugin("C2D1C858-740A-4CF0-9D0E-4FCA903E2FF8", typeof(BepInExPlugins.BepInExPlugin))]
    public sealed class DemosaicPlugin : GitPlugin
    {
        public DemosaicPlugin()
        {
            Author = PluginInfo.Author;
            GitUser = "DeathWeasel1337";
            GitRepository = "KK_Plugins";

            Entities = new GitEntityPlugin[]
            {
                new GitEntityPlugin()
                {
                    FileMask = @"\.v.*?\.zip",
                    Games = new Type[] { typeof(KoikatuGame) }
                }
            };
        }
    }
}
