using Core;
using Manager.Contents.Games;
using Manager.Contents.Plugins.BepInExPlugins;
using PluginSdk.Attributes;
using PluginSdk.Information;
using System;

namespace Manager.Contents.Plugins.IllusionModsPlugins
{
    [Language(LanguageType.English, "TextResourceRedirector", "Allows translations to override individual assets. Required for some translations to function correctly")]
    [Plugin("AEE81848-52BD-4864-9A93-FB9B82A45478", typeof(BepInExPlugin))]
    public sealed class TextResourceRedirectorPlugin : GitPlugin
    {
        public TextResourceRedirectorPlugin()
        {
            Author = PluginInfo.Author;
            GitUser = "IllusionMods";
            GitRepository = "TranslationTools";
            Entities = new GitEntityPlugin[]
            {
                new GitEntityPlugin()
                {
                    FileMask = @"KK_TextResourceRedirector\.v.*?\.zip",
                    Games = new Type[] { typeof(KoikatuGame) }
                },
                new GitEntityPlugin()
                {
                    FileMask = @"HS_TextResourceRedirector\.v.*?\.zip",
                    Games = new Type[] { typeof(HoneySelect1Game) }
                },
                new GitEntityPlugin()
                {
                    FileMask = @"HS2_TextResourceRedirector\.v.*?\.zip",
                    Games = new Type[] { typeof(HoneySelect2Game) }
                },
                new GitEntityPlugin()
                {
                    FileMask = @"AI_TextResourceRedirector\.v.*?\.zip",
                    Games = new Type[] { typeof(AiShoujoGame) }
                }
            };
        }
    }
}
