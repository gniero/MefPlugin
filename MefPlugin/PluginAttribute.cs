using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MefPlugin
{
    [MetadataAttribute]
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class PluginAttribute : ExportAttribute, INameMetadata
    {
        public PluginAttribute(string name) : base(typeof(IPlugin))
        {
            Name = name;
        }

        public string Name { get; }
    }
}
