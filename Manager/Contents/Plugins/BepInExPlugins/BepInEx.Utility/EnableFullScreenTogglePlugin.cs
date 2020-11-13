using Core;
using Manager.Contents.Games;
using PluginSdk.Attributes;
using PluginSdk.Information;
using System;

namespace Manager.Contents.Plugins.BepInExPlugins.BepInEx.Utility
{
    [Language(LanguageType.English, "EnableFullScreenToggle", "Enables toggling full screen with alt+enter on games with it disabled")]
    [Plugin("98D785A7-68CA-48D5-B986-F445F0B7EF27", typeof(BepInExPlugin))]
    public sealed class EnableFullScreenTogglePlugin : GitSharedPlugin
    {
        public EnableFullScreenTogglePlugin()
        {
            Author = PluginInfo.Author;
            GitUser = "BepInEx";
            GitRepository = "BepInEx.Utility";
            FileMask = @"BepInEx\.EnableFullScreenToggle\.v.*?\.zip";
            Games = new Type[] { typeof(KoikatuGame) };
        }
    }
}