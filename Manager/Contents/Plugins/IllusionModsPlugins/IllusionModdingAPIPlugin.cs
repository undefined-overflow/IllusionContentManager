using Core;
using Manager.Contents.Games;
using Manager.Contents.Plugins.BepInExPlugins;
using PluginSdk.Attributes;
using PluginSdk.Information;
using System;

namespace Manager.Contents.Plugins.IllusionModsPlugins
{
    [Language(LanguageType.English, "Modding API for Illusion games", "This is an API designed to make writing plugins for recent UnityEngine games made by the company Illusion easier and less bug-prone. It abstracts away a lot of the complexity of hooking the game save/load logic, creating interface elements at runtime, and many other tasks. All this while supplying many useful methods and tools")]
    [Plugin("AD005B57-2640-476F-8255-CAED7680B3E3", typeof(BepInExPlugin))]
    public sealed class IllusionModdingAPIPlugin : GitPlugin
    {
        public IllusionModdingAPIPlugin()
        {
            Author = PluginInfo.Author;
            GitUser = "IllusionMods";
            GitRepository = "IllusionModdingAPI";
            Entities = new GitEntityPlugin[]
            {
                new GitEntityPlugin()
                {
                    FileMask = @"KKAPI_.*?\.zip",
                    Games = new Type[] { typeof(KoikatsuGame), typeof(KoikatsuSteamGame) }
                },
                new GitEntityPlugin()
                {
                    FileMask = @"HS2API_.*?\.zip",
                    Games = new Type[] { typeof(HoneySelect2Game) }
                },
                new GitEntityPlugin()
                {
                    FileMask = @"AIAPI_.*?\.zip",
                    Games = new Type[] { typeof(AiShoujoGame) }
                }
            };
        }
    }
}
