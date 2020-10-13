using Core;
using GameSdk.Attributes;
using GameSdk.Information;
using Manager.Assets.Games;

namespace Manager.Contents.Games
{
    [Language(LanguageType.English, "AiShoujo")]
    [Game("CC7EEE84-6F53-4EDF-8AD3-3394EE777D72")]
    public class AiShoujoSteamGame : Game
    {
        public AiShoujoSteamGame()
        {
            Icon = IconInfo.AiShoujoSteamGame;
            Extensions = GameExtensions.Cards | GameExtensions.Plugins;
        }
    }
}