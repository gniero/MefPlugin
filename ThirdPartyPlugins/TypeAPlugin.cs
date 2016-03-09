using MefPlugin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdPartyPlugins
{
    [Plugin("PluginTypeA")]
    public class TypeAPlugin : IPlugin
    {
        public string PluginValue { get; set; }
    }
}
