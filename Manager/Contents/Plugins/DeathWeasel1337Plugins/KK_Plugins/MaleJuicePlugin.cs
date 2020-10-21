using Core;
using Manager.Contents.Games;
using PluginSdk.Attributes;
using PluginSdk.Information;
using System;

namespace Manager.Contents.Plugins.DeathWeasel1337Plugins.KK_Plugins
{
    [Language(LanguageType.English, "", "")]
    [Plugin("A479EB0A-5B18-4E35-A26A-219897E74BAF", typeof(BepInExPlugins.BepInExPlugin))]
    public sealed class MaleJuicePlugin : GitPlugin
    {
        public MaleJuicePlugin()
        {
            Author = PluginInfo.Author;
            GitUser = "DeathWeasel1337";
            GitRepository = "KK_Plugins";

            Entities = new GitEntityPlugin[]
            {
                new GitEntityPlugin()
                {
                    FileMask = @"\.v.*?\.zip",
                    Games = new Type[] { typeof(KoikatsuGame) }
                }
            };
        }
    }
}
