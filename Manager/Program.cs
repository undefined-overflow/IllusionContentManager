using Manager.Generators;
using System.IO;
using System.Threading.Tasks;

namespace Manager
{
    public class Program
    {
        private static async Task Main()
        {
            var q = Directory.GetCurrentDirectory();

            await PluginGenerator.Save();
            await GameGenerator.Save();
        }
    }
}