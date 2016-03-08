using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MefPlugin
{
    public interface IPlugin
    {
        string PluginValue { get; set; }
    }
}
