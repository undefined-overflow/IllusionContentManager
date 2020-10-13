using PluginSdk.Information;

namespace Manager.Contents.Plugins.IllusionModsPlugins
{
    public class PluginInfo
    {
        public static readonly Author Author = new Author()
        {
            Name = "IllusionMods",
            Urls = new AuthorUrl[]
            {
                new() { Url = "https://github.com/IllusionMods", Type = AuthorUrlType.Git }
            }
        };
    }
}