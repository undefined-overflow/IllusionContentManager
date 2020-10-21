using Core;
using Manager.Contents.Games;
using PluginSdk.Attributes;
using PluginSdk.Information;
using System;

namespace Manager.Contents.Plugins.DeathWeasel1337Plugins.KK_Plugins
{
    [Language(LanguageType.English, "CharacterExport", "Press Ctrl+E (configurable) to export all loaded character. Used for exporting characters from Studio scenes and such")]
    [Plugin("E7035CFC-8497-4C2B-8EEB-C0ABDA687329", typeof(BepInExPlugins.BepInExPlugin))]
    public sealed class CharacterExportPlugin : GitPlugin
    {
        public CharacterExportPlugin()
        {
            Author = PluginInfo.Author;
            GitUser = "DeathWeasel1337";
            GitRepository = "KK_Plugins";

            Entities = new GitEntityPlugin[]
            {
                new()
                {
                    FileMask = @"AI_CharacterExport\.v.*?\.zip",
                    Games = new Type[] { typeof(AiShoujoGame) }
                },
                new()
                {
                    FileMask = @"KK_CharacterExport\.v.*?\.zip",
                    Games = new Type[] { typeof(KoikatsuGame) }
                },
                new()
                {
                    FileMask = @"HS2_CharacterExport\.v.*?\.zip",
                    Games = new Type[] { typeof(HoneySelect2Game) }
                },
                new()
                {
                    FileMask = @"EC_CharacterExport\.v.*?\.zip",
                    Games = new Type[] { typeof(HoneySelect2Game) }
                }
            };
        }
    }
}