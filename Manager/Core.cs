using System.IO;

namespace Manager
{
    public static class Core
    {
        public static readonly string WebDir = Path.GetFullPath(Path.Join("..", "illusion-package-manager"));
        public static readonly string FakeDir = Path.GetFullPath(Path.Join("fake-api", "wwwroot"));
    }
}