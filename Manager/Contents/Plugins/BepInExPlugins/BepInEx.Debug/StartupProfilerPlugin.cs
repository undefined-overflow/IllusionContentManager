using Core;
using Manager.Contents.Games;
using PluginSdk.Attributes;
using PluginSdk.Information;
using System;

namespace Manager.Contents.Plugins.BepInExPlugins.BepInEx.Debug
{
    [Language(LanguageType.English, "Startup Profiler", "Log and report the time spent in the Start, Awake, Main, .ctor and .cctor methods of each plugin")]
    [Plugin("DCB8723B-F5B1-4EE6-AFDC-E4FCB4895411", typeof(BepInExPlugin))]
    public sealed class StartupProfilerPlugin : GitSharedPlugin
    {
        public StartupProfilerPlugin()
        {
            Author = PluginInfo.Author;
            GitUser = "BepInEx";
            GitRepository = "BepInEx.Debug";
            FileMask = @"StartupProfiler_v.*?\.zip";
            Games = new Type[] { typeof(KoikatuGame) };
        }
    }
}