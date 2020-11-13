using Core;
using Manager.Contents.Games;
using PluginSdk.Attributes;
using PluginSdk.Information;
using System;

namespace Manager.Contents.Plugins.DeathWeasel1337Plugins.KK_Plugins
{
    [Language(LanguageType.English, "", "")]
    [Plugin("657DE82A-E4C9-4E5F-BB35-E9405A6AA991", typeof(BepInExPlugins.BepInExPlugin))]
    public sealed class CharaMakerLoadedSoundPlugin : GitPlugin
    {
        public CharaMakerLoadedSoundPlugin()
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
