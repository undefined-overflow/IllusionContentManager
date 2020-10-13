using System.Collections.Generic;

namespace PluginSdk.Information
{
    public class Author
    {
        public string Name { get; init; }
        public IReadOnlyList<AuthorUrl> Urls { get; init; }
    }
}