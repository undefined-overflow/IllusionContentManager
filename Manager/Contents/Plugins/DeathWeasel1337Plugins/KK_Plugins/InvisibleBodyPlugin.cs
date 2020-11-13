using Core;
using Manager.Contents.Games;
using PluginSdk.Attributes;
using PluginSdk.Information;
using System;

namespace Manager.Contents.Plugins.DeathWeasel1337Plugins.KK_Plugins
{
    [Language(LanguageType.English, "", "")]
    [Plugin("AF56D02B-39BE-4FDC-B197-EF1F0E5F0BC0", typeof(BepInExPlugins.BepInExPlugin))]
    public sealed class InvisibleBodyPlugin : GitPlugin
    {
        public InvisibleBodyPlugin()
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
