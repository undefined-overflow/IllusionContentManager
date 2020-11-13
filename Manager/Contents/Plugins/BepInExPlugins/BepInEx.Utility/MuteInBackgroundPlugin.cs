using Core;
using Manager.Contents.Games;
using PluginSdk.Attributes;
using PluginSdk.Information;
using System;

namespace Manager.Contents.Plugins.BepInExPlugins.BepInEx.Utility
{
    [Language(LanguageType.English, "MuteInBackground", "Adds an option to mute a game when it loses focus, i.e. when alt-tabbed. Must be enabled in the plugin config either by editing the plugin's .cfg file or by using ConfigurationManager")]
    [Plugin("7E92BDE0-779F-4730-9511-63C04B4FC563", typeof(BepInExPlugin))]
    public sealed class MuteInBackgroundPlugin : GitSharedPlugin
    {
        public MuteInBackgroundPlugin()
        {
            Author = PluginInfo.Author;
            GitUser = "BepInEx";
            GitRepository = "BepInEx.Utility";
            FileMask = @"BepInEx\.MuteInBackground\.v.*?\.zip";
            Games = new Type[] { typeof(KoikatuGame) };
        }
    }
}