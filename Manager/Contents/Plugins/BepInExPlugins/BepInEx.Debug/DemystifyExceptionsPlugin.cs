using Core;
using Manager.Contents.Games;
using PluginSdk.Attributes;
using PluginSdk.Information;
using System;

namespace Manager.Contents.Plugins.BepInExPlugins.BepInEx.Debug
{
    [Language(LanguageType.English, "DemystifyExceptions", "Turns exceptions into a more readable format. Resolves enumerators, lambdas and other complex structures")]
    [Plugin("C85F38BC-8723-4816-9AA3-3EC477853140", typeof(BepInExPlugin))]
    public sealed class DemystifyExceptionsPlugin : GitSharedPlugin
    {
        public DemystifyExceptionsPlugin()
        {
            Author = PluginInfo.Author;
            GitUser = "BepInEx";
            GitRepository = "BepInEx.Debug";
            FileMask = @"DemystifyExceptions_v.*?\.zip";
            Games = new Type[] { typeof(KoikatuGame) };
        }
    }
}