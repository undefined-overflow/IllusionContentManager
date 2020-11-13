using Core;
using Manager.Contents.Games;
using Manager.Contents.Plugins.BepInExPlugins;
using PluginSdk.Attributes;
using PluginSdk.Information;
using System;

namespace Manager.Contents.Plugins.IllusionModsPlugins
{
    [Language(LanguageType.English, "TranslationSync", "A plugin for correctly formatting translation files. Corrects formatting and copies translations from one file to another for the same personality in case of duplicate entries. Used by translators working on the Koikatsu Story Translation project. No need to download unless you're working on translations")]
    [Plugin("0632167C-AAFC-488B-AF53-18BE903CFF0F", typeof(BepInExPlugin))]
    public sealed class TranslationSyncPlugin : GitPlugin
    {
        public TranslationSyncPlugin()
        {
            Author = PluginInfo.Author;
            GitUser = "IllusionMods";
            GitRepository = "TranslationTools";
            Entities = new GitEntityPlugin[]
            {
                new GitEntityPlugin()
                {
                    FileMask = @"KK_TranslationSync\.v.*?\.zip",
                    Games = new Type[] { typeof(KoikatuGame) }
                },
            };
        }
    }
}
