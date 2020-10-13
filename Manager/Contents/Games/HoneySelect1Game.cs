using Core;
using GameSdk.Attributes;
using GameSdk.Information;
using Manager.Assets.Games;

namespace Manager.Contents.Games
{
    [Language(LanguageType.English, "HoneySelect 1")]
    [Game("7011D210-0D02-4BBE-BAFF-AF47D15BC75C")]
    public class HoneySelect1Game : Game
    {
        public HoneySelect1Game()
        {
            Icon = IconInfo.HoneySelect1;
            Extensions = GameExtensions.Cards | GameExtensions.Plugins;
        }
    }
}