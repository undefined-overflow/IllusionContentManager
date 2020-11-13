using Core;
using Manager.Contents.Games;
using PluginSdk.Attributes;
using PluginSdk.Information;
using System;

namespace Manager.Contents.Plugins.BepInExPlugins.BepInEx.Debug
{
    [Language(LanguageType.English, "MirrorInternalLogs", "This preloader patcher allows to capture and mirror Unity internal debug logs (i.e. the contents of output_log.txt)")]
    [Plugin("28B15D81-BA13-413C-8290-3D9D6997AA55", typeof(BepInExPlugin))]
    public sealed class MirrorInternalLogsPlugin : GitSharedPlugin
    {
        public MirrorInternalLogsPlugin()
        {
            Author = PluginInfo.Author;
            GitUser = "BepInEx";
            GitRepository = "BepInEx.Debug";
            FileMask = @"MirrorInternalLogs_v.*?\.zip";
            Games = new Type[] { typeof(KoikatuGame) };
        }
    }
}