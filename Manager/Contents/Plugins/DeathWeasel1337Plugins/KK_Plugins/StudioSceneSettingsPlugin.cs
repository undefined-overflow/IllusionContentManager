using Core;
using Manager.Contents.Games;
using PluginSdk.Attributes;
using PluginSdk.Information;
using System;

namespace Manager.Contents.Plugins.DeathWeasel1337Plugins.KK_Plugins
{
    [Language(LanguageType.English, "", "")]
    [Plugin("6CB836C1-46A4-4295-B3C7-2B6792443C95", typeof(BepInExPlugins.BepInExPlugin))]
    public sealed class StudioSceneSettingsPlugin : GitPlugin
    {
        public StudioSceneSettingsPlugin()
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
