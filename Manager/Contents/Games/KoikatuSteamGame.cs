using Core;
using GameSdk.Attributes;
using GameSdk.Information;
using Manager.Assets.Games;

namespace Manager.Contents.Games
{
    [Language(LanguageType.English, "Koikatu (steam)")]
    [Game("C9392167-A87A-44FE-87DF-8173A57645D7")]
    public class KoikatuSteamGame : Game
    {
        public KoikatuSteamGame()
        {
            Icon = IconInfo.Koikatsu;
            Exe = "Koikatu";
            Extensions = GameExtensions.Cards | GameExtensions.Plugins;
        }
    }
}