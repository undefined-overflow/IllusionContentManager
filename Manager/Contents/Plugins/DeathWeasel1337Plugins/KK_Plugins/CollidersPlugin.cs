using Core;
using Manager.Contents.Games;
using PluginSdk.Attributes;
using PluginSdk.Information;
using System;

namespace Manager.Contents.Plugins.DeathWeasel1337Plugins.KK_Plugins
{
    [Language(LanguageType.English, "", "")]
    [Plugin("7CE8F2E1-2BE0-47E9-84B1-1DAABEA7F911", typeof(BepInExPlugins.BepInExPlugin))]
    public sealed class CollidersPlugin : GitPlugin
    {
        public CollidersPlugin()
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
