using PluginSdk.Information;

namespace Manager.Contents.Plugins.DeathWeasel1337Plugins
{
    public class PluginInfo
    {
        public static readonly Author Author = new Author()
        {
            Name = "DeathWeasel1337",
            Urls = new AuthorUrl[]
            {
                new AuthorUrl() { Url = "https://github.com/DeathWeasel1337", Type = AuthorUrlType.Git }
            }
        };
    }
}