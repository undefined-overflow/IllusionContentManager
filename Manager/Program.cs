using Manager.Generators;
using System;
using System.Threading.Tasks;

namespace Manager
{
    public class Program
    {
        private static async Task Main()
        {
            Console.WriteLine("Main start");

            await Task.WhenAll(PluginGenerator.Save(), GameGenerator.Save());

            Console.WriteLine("Main done");
        }
    }
}