using MefDemo.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Composition.Hosting;
using System.IO;
using Mef.Demo.Contracts;

namespace ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var components = new CompositionHelper().Imports;

            foreach (var component in components)
            {
                component.Value.Search();
            }

            Console.ReadLine();
        }
    }
}
