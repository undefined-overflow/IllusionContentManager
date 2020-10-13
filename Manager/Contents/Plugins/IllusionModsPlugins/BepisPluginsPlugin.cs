using Core;
using Manager.Contents.Games;
using Manager.Contents.Plugins.BepInExPlugins;
using PluginSdk.Attributes;
using PluginSdk.Information;
using System;

namespace Manager.Contents.Plugins.IllusionModsPlugins.Koikatsu
{
    [Language(LanguageType.English, "BepisPlugins", "A collection of essential BepInEx plugins for Koikatu / Koikatsu Party, EmotionCreators, AI-Shoujo / AI-Girl, HoneySelect2 and other games by Illusion")]
    [Plugin("191BFC5F-EE47-45B7-913A-14637F8534A7", typeof(BepInExPlugin))]
    public sealed class BepisPluginsPlugin : GitPlugin
    {
        public BepisPluginsPlugin()
        {
            Author = PluginInfo.Author;
            GitUser = "IllusionMods";
            GitRepository = "BepisPlugins";
            Entities = new GitEntityPlugin[]
            {
                new()
                {
                    FileMask = @"KK_BepisPlugins_r.*?\.zip",
                    Games = new Type[] { typeof(KoikatsuGame) }
                }
            };
        }
    }
}