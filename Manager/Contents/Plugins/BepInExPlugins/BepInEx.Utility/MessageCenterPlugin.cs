using Core;
using Manager.Contents.Games;
using PluginSdk.Attributes;
using PluginSdk.Information;
using System;

namespace Manager.Contents.Plugins.BepInExPlugins.BepInEx.Utility
{
    [Language(LanguageType.English, "MessageCenter", "A simple plugin that shows any log entries marked as \"Message\" on screen. Plugins generally use the \"Message\" log level for things that they want the user to read")]
    [Plugin("C32495D7-FBCD-4691-8A69-5BE22A909D35", typeof(BepInExPlugin))]
    public sealed class MessageCenterPlugin : GitSharedPlugin
    {
        public MessageCenterPlugin()
        {
            Author = PluginInfo.Author;
            GitUser = "BepInEx";
            GitRepository = "BepInEx.Utility";
            FileMask = @"BepInEx\.MessageCenter\.v.*?\.zip";
            Games = new Type[] { typeof(KoikatsuGame) };
        }
    }
}