using Core;
using GameSdk.Attributes;
using GameSdk.Information;
using Manager.Assets.Games;

namespace Manager.Contents.Games
{
    [Language(LanguageType.English, "Koikatu")]
    [Game("DD577C14-B0F5-47B1-ADAE-7000E047C4DA")]
    public class KoikatuGame : Game
    {
        public KoikatuGame()
        {
            Icon = IconInfo.Koikatsu;
            Exe = "Koikatu";
            Extensions = GameExtensions.Cards | GameExtensions.Plugins;
        }
    }
}