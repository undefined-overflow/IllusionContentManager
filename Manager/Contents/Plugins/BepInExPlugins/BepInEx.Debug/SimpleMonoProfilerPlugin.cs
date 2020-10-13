using Core;
using Manager.Contents.Games;
using PluginSdk.Attributes;
using PluginSdk.Information;
using System;

namespace Manager.Contents.Plugins.BepInExPlugins.BepInEx.Debug
{
    [Language(LanguageType.English, "Simple Mono Profiler", "A simple profiler that can be used in any Unity player build as long as it can run BepInEx 5.x. It can generate a .csv file with profiling results from an arbitrary length of time")]
    [Plugin("6A94D7E0-1070-4507-8ED3-92B884364C28", typeof(BepInExPlugin))]
    public sealed class SimpleMonoProfilerPlugin : GitSharedPlugin
    {
        public SimpleMonoProfilerPlugin()
        {
            Author = PluginInfo.Author;
            GitUser = "BepInEx";
            GitRepository = "BepInEx.Debug";
            FileMask = @"SimpleMonoProfiler_v.*?\.zip";
            Games = new Type[] { typeof(KoikatsuGame) };
        }
    }
}