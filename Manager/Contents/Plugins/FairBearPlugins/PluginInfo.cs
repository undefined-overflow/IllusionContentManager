using PluginSdk.Information;

namespace Manager.Contents.Plugins.FairBearPlugins
{
    public static class PluginInfo
    {
        public static readonly Author Author = new Author()
        {
            Name = "FairBear",
            Urls = new AuthorUrl[]
            {
                new AuthorUrl() { Url = "https://github.com/FairBear", Type = AuthorUrlType.Git }
            }
        };
    }
}