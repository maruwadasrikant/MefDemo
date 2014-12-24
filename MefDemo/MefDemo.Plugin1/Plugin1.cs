using Mef.Demo.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MefDemo.Plugin1
{
    [Export(typeof(ISearchEngine))]
    [ExportMetadata("Plugin1", "Plugin1")]
    public class Plugin1 : ISearchEngine
    {
        public void Search()
        {
            Console.WriteLine("from plugin 1");
        }
    }
}
