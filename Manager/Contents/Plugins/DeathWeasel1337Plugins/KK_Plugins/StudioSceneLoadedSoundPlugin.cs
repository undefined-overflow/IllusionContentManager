using Core;
using Manager.Contents.Games;
using PluginSdk.Attributes;
using PluginSdk.Information;
using System;

namespace Manager.Contents.Plugins.DeathWeasel1337Plugins.KK_Plugins
{
    [Language(LanguageType.English, "", "")]
    [Plugin("5B3D4D6D-3A3B-4892-9A2C-1BDD3A3A2D0F", typeof(BepInExPlugins.BepInExPlugin))]
    public sealed class StudioSceneLoadedSoundPlugin : GitPlugin
    {
        public StudioSceneLoadedSoundPlugin()
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