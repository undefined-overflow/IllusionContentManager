using System.IO;

namespace Manager
{
  public static class Core
  {
    public static readonly string WebDir = Path.GetFullPath(@"..\illusion-package-manager");
    public static readonly string FakeDir = Path.GetFullPath(@"fake-api\wwwroot");
  }
}
