using Core;
using Manager.Contents.Games;
using PluginSdk.Attributes;
using PluginSdk.Information;
using System;

namespace Manager.Contents.Plugins.BepInExPlugins
{
    [Language(LanguageType.English, "BepInEx", "Bepis Injector Extensible")]
    [Plugin("E89BBD92-DF1B-4E9E-ADD4-292DDA4B2292")]
    public sealed class BepInExPlugin : GitSharedPlugin
    {
        public BepInExPlugin()
        {
            Author = PluginInfo.Author;
            GitUser = "BepInEx";
            GitRepository = "BepInEx";
            FileMask = @"BepInEx_x64_.*?\.zip";
            Games = new Type[] { typeof(KoikatsuGame), typeof(KoikatsuSteamGame) };
        }
    }
}