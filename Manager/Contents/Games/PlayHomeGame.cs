using Core;
using GameSdk.Attributes;
using GameSdk.Information;
using Manager.Assets.Games;

namespace Manager.Contents.Games
{
    [Language(LanguageType.English, "PlayHome")]
    [Game("2C27FD85-6697-4CEF-A1C4-87E8E414EAC0")]
    public class PlayHomeGame : Game
    {
        public PlayHomeGame()
        {
            Icon = IconInfo.PlayHome;
            Extensions = GameExtensions.Cards | GameExtensions.Plugins;
        }
    }
}