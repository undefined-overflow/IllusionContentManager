using Core;
using Manager.Contents.Games;
using PluginSdk.Attributes;
using PluginSdk.Information;
using System;

namespace Manager.Contents.Plugins.BepInExPlugins.BepInEx.Utility
{
    [Language(LanguageType.English, "EnableResize", "Enable window resizing. Must be enabled in the plugin config either by editing the plugin's .cfg file or by using ConfigurationManager")]
    [Plugin("228263F0-FF01-4CDE-8DDD-FBDE23DA90BC", typeof(BepInExPlugin))]
    public sealed class Plugin : GitSharedPlugin
    {
        public Plugin()
        {
            Author = PluginInfo.Author;
            GitUser = "BepInEx";
            GitRepository = "BepInEx.Utility";
            FileMask = @"BepInEx\.EnableResize\.v.*?\.zip";
            Games = new Type[] { typeof(KoikatsuGame) };
        }
    }
}