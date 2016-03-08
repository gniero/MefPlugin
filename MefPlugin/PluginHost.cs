using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MefPlugin
{
    public class PluginHost
    {
        [ImportMany]
        public IEnumerable<ExportFactory<IPlugin, INameMetadata>> PluginFactory;
            
        public PluginHost()
        {
            var catalog = new AssemblyCatalog(Assembly.GetExecutingAssembly());

            var container = new CompositionContainer(catalog);
            container.ComposeParts(this);
        }

        public IPlugin CreatePlugin(string name)
        {
            return PluginFactory.First(x => x.Metadata.Name == name).CreateExport().Value;
        }

        public IEnumerable<string> ListAllPluginTypes()
        {
            return PluginFactory.Select(x => x.Metadata.Name);
        }

    }
}
