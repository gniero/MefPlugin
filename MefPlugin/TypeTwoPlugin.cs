using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MefPlugin
{
    [Plugin("PluginTwo")]
    public class TypeTwoPlugin : IPlugin
    {
        public string PluginValue { get; set; }
    }
}
