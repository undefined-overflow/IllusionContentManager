using Core;
using GameSdk.Attributes;
using GameSdk.Information;
using Manager.Assets.Games;

namespace Manager.Contents.Games
{
    [Language(LanguageType.English, "EmotionCreators")]
    [Game("AF55AC77-FC9D-4FF5-B4EA-9A2A0C95C63C")]
    public class EmotionCreatorsGame : Game
    {
        public EmotionCreatorsGame()
        {
            Icon = IconInfo.EmotionCreators;
            Extensions = GameExtensions.Cards | GameExtensions.Plugins;
        }
    }
}