using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MefPlugin
{
    class Program
    {
        static void Main(string[] args)
        {

            PluginHost host = new PluginHost();

            Console.WriteLine("Available: ");

            foreach (var s in host.ListAllPluginTypes())
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();
            var plugin1_1 = host.CreatePlugin("PluginOne");
            var plugin1_2 = host.CreatePlugin("PluginOne");
            var plugin2_1 = host.CreatePlugin("PluginTwo");
            var plugin2_2 = host.CreatePlugin("PluginTwo");

            Console.WriteLine(string.Format("Plugin 1_1: {0}", plugin1_1.GetHashCode()));
            Console.WriteLine(string.Format("Plugin 1_2: {0}", plugin1_2.GetHashCode()));
            Console.WriteLine(string.Format("Plugin 2_1: {0}", plugin2_1.GetHashCode()));
            Console.WriteLine(string.Format("Plugin 2_2: {0}", plugin2_2.GetHashCode()));


            Console.ReadKey();

        }
    }
}
