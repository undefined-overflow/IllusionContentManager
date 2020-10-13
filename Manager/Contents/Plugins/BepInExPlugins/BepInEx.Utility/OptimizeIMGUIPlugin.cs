using Core;
using Manager.Contents.Games;
using PluginSdk.Attributes;
using PluginSdk.Information;
using System;

namespace Manager.Contents.Plugins.BepInExPlugins.BepInEx.Utility
{
    [Language(LanguageType.English, "OptimizeIMGUI", "Reduce unnecessary GC allocations of Unity's IMGUI (OnGUI) interface system. It fixes the passive GC allocations that happen every frame caused by using any OnGUI code at all, and reduces GC allocations for OnGUI code")]
    [Plugin("A4ED82CD-D06E-4691-A2A3-88153CFBD729", typeof(BepInExPlugin))]
    public sealed class OptimizeIMGUIPlugin : GitSharedPlugin
    {
        public OptimizeIMGUIPlugin()
        {
            Author = PluginInfo.Author;
            GitUser = "BepInEx";
            GitRepository = "BepInEx.Utility";
            FileMask = @"BepInEx\.OptimizeIMGUI\.v.*?\.zip";
            Games = new Type[] { typeof(KoikatsuGame) };
        }
    }
}