using Core;
using Manager.Contents.Games;
using PluginSdk.Attributes;
using PluginSdk.Information;
using System;

namespace Manager.Contents.Plugins.DeathWeasel1337Plugins.KK_Plugins
{
    [Language(LanguageType.English, "AnimationController", "Allows attaching IK nodes to objects to create custom animations. Press the Minus (-) hotkey to bring up the menu. This hotkey can be configured in the F1 plugin settings")]
    [Plugin("0FE08D74-85E1-4E4C-9904-4D7AD7961764", typeof(BepInExPlugins.BepInExPlugin), typeof(IllusionModsPlugins.IllusionModdingAPIPlugin))]
    public sealed class AnimationControllerPlugin : GitPlugin
    {
        public AnimationControllerPlugin()
        {
            Author = PluginInfo.Author;
            GitUser = "DeathWeasel1337";
            GitRepository = "KK_Plugins";

            Entities = new GitEntityPlugin[]
            {
                new GitEntityPlugin()
                {
                    FileMask = @"AI_AnimationController\.v.*?\.zip",
                    Games = new Type[] { typeof(AiShoujoGame) }
                },
                new GitEntityPlugin()
                {
                    FileMask = @"KK_AnimationController\.v.*?\.zip",
                    Games = new Type[] { typeof(KoikatsuGame) }
                },
                new GitEntityPlugin()
                {
                    FileMask = @"HS2_AnimationController\.v.*?\.zip",
                    Games = new Type[] { typeof(HoneySelect2Game) }
                }
            };
        }
    }
}
