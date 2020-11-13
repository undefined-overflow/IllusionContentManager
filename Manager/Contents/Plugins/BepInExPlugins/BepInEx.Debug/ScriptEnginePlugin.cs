using Core;
using Manager.Contents.Games;
using PluginSdk.Attributes;
using PluginSdk.Information;
using System;

namespace Manager.Contents.Plugins.BepInExPlugins.BepInEx.Debug
{
    [Language(LanguageType.English, "ScriptEngine", "Loads and reloads BepInEx plugins from the BepInEx\\scripts folder. User can reload all of these plugins by pressing the keyboard shortcut defined in the config. Shortcut is F6 by default")]
    [Plugin("A0CF9A40-500D-406E-90BE-C0F83177ED1E", typeof(BepInExPlugin))]
    public sealed class ScriptEnginePlugin : GitSharedPlugin
    {
        public ScriptEnginePlugin()
        {
            Author = PluginInfo.Author;
            GitUser = "BepInEx";
            GitRepository = "BepInEx.Debug";
            FileMask = @"ScriptEngine_v.*?\.zip";
            Games = new Type[] { typeof(KoikatuGame) };
        }
    }
}