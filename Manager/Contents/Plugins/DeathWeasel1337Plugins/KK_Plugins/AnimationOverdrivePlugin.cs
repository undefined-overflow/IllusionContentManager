using Core;
using Manager.Contents.Games;
using PluginSdk.Attributes;
using PluginSdk.Information;
using System;

namespace Manager.Contents.Plugins.DeathWeasel1337Plugins.KK_Plugins
{
    [Language(LanguageType.English, "AnimationOverdrive", "Type in to the animation speed box in Studio for gimmicks and character animations to go past the normal limit of 3")]
    [Plugin("B9283A7A-7613-44C3-85C6-BC97DD4DAF80", typeof(BepInExPlugins.BepInExPlugin))]
    public sealed class AnimationOverdrivePlugin : GitPlugin
    {
        public AnimationOverdrivePlugin()
        {
            Author = PluginInfo.Author;
            GitUser = "DeathWeasel1337";
            GitRepository = "KK_Plugins";

            Entities = new GitEntityPlugin[]
            {
                new GitEntityPlugin()
                {
                    FileMask = @"AI_AnimationOverdrive\.v.*?\.zip",
                    Games = new Type[] { typeof(AiShoujoGame) }
                },
                new GitEntityPlugin()
                {
                    FileMask = @"KK_AnimationOverdrive\.v.*?\.zip",
                    Games = new Type[] { typeof(KoikatuGame) }
                },
                new GitEntityPlugin()
                {
                    FileMask = @"HS2_AnimationOverdrive\.v.*?\.zip",
                    Games = new Type[] { typeof(HoneySelect2Game) }
                }
            };
        }
    }
}
