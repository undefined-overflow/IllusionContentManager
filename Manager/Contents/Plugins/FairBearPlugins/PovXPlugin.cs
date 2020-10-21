using Core;
using Manager.Contents.Games;
using Manager.Contents.Plugins.BepInExPlugins;
using PluginSdk.Attributes;
using PluginSdk.Information;
using System;

namespace Manager.Contents.Plugins.FairBearPlugins
{
    [Language(LanguageType.English, "KK_PovX", "PoV plugin")]
    [Plugin("166243FC-F6A8-4F9D-8121-0E373D6495DB", typeof(BepInExPlugin))]
    public class PovXPlugin : GitPlugin
    {
        public PovXPlugin()
        {
            Author = PluginInfo.Author;
            GitUser = "FairBear";
            GitRepository = "KK_PovX";
            Entities = new GitEntityPlugin[]
            {
                new()
                {
                    FileMask = @"KK_PovX\.v.*?\.zip",
                    Games = new Type[] { typeof(KoikatsuGame) }
                }
            };
        }
    }
}