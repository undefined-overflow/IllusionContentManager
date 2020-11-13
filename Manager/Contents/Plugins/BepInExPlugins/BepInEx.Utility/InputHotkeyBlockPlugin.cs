using Core;
using Manager.Contents.Games;
using PluginSdk.Attributes;
using PluginSdk.Information;
using System;

namespace Manager.Contents.Plugins.BepInExPlugins.BepInEx.Utility
{
    [Language(LanguageType.English, "InputHotkeyBlock", "Prevents plugin hotkeys from triggering while typing in an input field")]
    [Plugin("F853E45B-6624-4E97-B5DB-43E04801EB2E", typeof(BepInExPlugin))]
    public sealed class InputHotkeyBlockPlugin : GitSharedPlugin
    {
        public InputHotkeyBlockPlugin()
        {
            Author = PluginInfo.Author;
            GitUser = "BepInEx";
            GitRepository = "BepInEx.Utility";
            FileMask = @"BepInEx\.InputHotkeyBlock\.v.*?\.zip";
            Games = new Type[] { typeof(KoikatuGame) };
        }
    }
}