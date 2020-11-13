using Core;
using Manager.Contents.Games;
using PluginSdk.Attributes;
using PluginSdk.Information;
using System;

namespace Manager.Contents.Plugins.BepInExPlugins
{
    [Language(LanguageType.English, "BepInEx.ConfigurationManager", "Mod configuration manager for BepInEx 5")]
    [Plugin("8D62C33D-97A1-4D6D-BC52-798B0A895032", typeof(BepInExPlugin))]
    public sealed class ConfigurationManagerPlugin : GitSharedPlugin
    {
        public ConfigurationManagerPlugin()
        {
            Author = PluginInfo.Author;
            GitUser = "BepInEx";
            GitRepository = "BepInEx.ConfigurationManager";
            FileMask = @"BepInEx\.ConfigurationManager_v.*?\.zip";
            Games = new Type[] { typeof(KoikatuGame) };
        }
    }
}