using Mef.Demo.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MefDemo.Plugin2
{
    [Export(typeof(ISearchEngine))]
    [ExportMetadata("Plugin2", "Plugin2")]
    public class Plugin2 : ISearchEngine
    {
        public void Search()
        {
            Console.WriteLine("from plugin 2");
        }
    }
}
