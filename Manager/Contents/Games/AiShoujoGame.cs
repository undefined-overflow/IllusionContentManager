using Core;
using GameSdk.Attributes;
using GameSdk.Information;
using Manager.Assets.Games;

namespace Manager.Contents.Games
{
    [Language(LanguageType.English, "AiShoujo (steam)")]
    [Game("4BA4FFA1-B335-4F99-A81F-237DF78BB3E2")]
    public class AiShoujoGame : Game
    {
        public AiShoujoGame()
        {
            Icon = IconInfo.AiShoujoGame;
            Exe = "AiShoujo";
            Extensions = GameExtensions.Cards | GameExtensions.Plugins;
        }
    }
}