using Core;
using GameSdk.Attributes;
using GameSdk.Information;
using Manager.Assets.Games;

namespace Manager.Contents.Games
{
    [Language(LanguageType.English, "Koikatsu")]
    [Game("DD577C14-B0F5-47B1-ADAE-7000E047C4DA")]
    public class KoikatsuGame : Game
    {
        public KoikatsuGame()
        {
            Icon = IconInfo.Koikatsu;
            Exe = "Koikatsu";
            Extensions = GameExtensions.Cards | GameExtensions.Plugins;
        }
    }
}