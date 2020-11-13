using Core;
using GameSdk.Attributes;
using GameSdk.Information;
using Manager.Assets.Games;

namespace Manager.Contents.Games
{
    [Language(LanguageType.English, "HoneySelect 2")]
    [Game("565CAD20-C4CF-45FB-B3B3-61FC7F726A81")]
    public class HoneySelect2Game : Game
    {
        public HoneySelect2Game()
        {
            Icon = IconInfo.HoneySelect2;
            Exe = "HoneySelect2";
            Extensions = GameExtensions.Cards | GameExtensions.Plugins;
        }
    }
}