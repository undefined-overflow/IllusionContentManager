using PluginSdk.Information;

namespace Manager.Contents.Plugins.BepInExPlugins
{
    public static class PluginInfo
    {
        public static readonly Author Author = new Author()
        {
            Name = "BepInEx",
            Urls = new AuthorUrl[]
            {
                new AuthorUrl() { Url = "https://github.com/BepInEx", Type = AuthorUrlType.Git }
            }
        };
    }
}