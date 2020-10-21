using System.Collections.Generic;

namespace PluginSdk.Information
{
  public class Author
  {
    public string Name { get; set; }
    public IReadOnlyList<AuthorUrl> Urls { get; set; }
  }
}
