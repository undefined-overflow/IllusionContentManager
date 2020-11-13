using Core;
using Manager.Contents.Games;
using PluginSdk.Attributes;
using PluginSdk.Information;
using System;

namespace Manager.Contents.Plugins.BepInExPlugins
{
    [Language(LanguageType.English, "IPALoaderX", "IPALoaderX is a plugin for BepInEx that allows to load plugins made for Illusion Plugin Architecture without installing it")]
    [Plugin("23104D56-579C-45CF-88DD-9C4E618C169C", typeof(BepInExPlugin))]
    public sealed class IPALoaderXPlugin : GitSharedPlugin
    {
        public IPALoaderXPlugin()
        {
            Author = PluginInfo.Author;
            GitUser = "BepInEx";
            GitRepository = "IPALoaderX";
            FileMask = @"BepInEx\.IPALoader\.v.*?\.zip";
            Games = new Type[] { typeof(KoikatuGame) };
        }
    }
}