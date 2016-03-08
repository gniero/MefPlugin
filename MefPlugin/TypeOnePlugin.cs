using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MefPlugin
{
    [Plugin("PluginOne")]
    public class TypeOnePlugin : IPlugin
    {
        public string PluginValue { get; set; }
    }
}
