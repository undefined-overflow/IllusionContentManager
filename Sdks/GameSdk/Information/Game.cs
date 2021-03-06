﻿namespace GameSdk.Information
{
    public enum GameExtensions
    {
        Plugins = 1,
        Cards = 2,
        Folders = 4
    }

    public abstract class Game
    {
        public string Icon { get; set; }

        public string Exe { get; set; }

        public GameExtensions Extensions { get; set; }
    }
}