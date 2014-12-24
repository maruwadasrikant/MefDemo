using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mef.Demo.Contracts;
using System.ComponentModel.Composition.Hosting;
using System.IO;

namespace MefDemo.Common
{
    public class CompositionHelper
    {
        [ImportMany(typeof(ISearchEngine),AllowRecomposition=true)]
        public IEnumerable<Lazy<ISearchEngine>> Imports { get; set; }

        public CompositionHelper()
        {
            AggregateCatalog catalog = new AggregateCatalog();
            //String root = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "bin");
            //String[] folders = Directory.GetDirectories(AppDomain.CurrentDomain.BaseDirectory, "*", SearchOption.AllDirectories);
            //foreach (var folder in folders)
            //{
            //    catalog.Catalogs.Add(new DirectoryCatalog(folder));
            //}
            catalog.Catalogs.Add(new DirectoryCatalog(AppDomain.CurrentDomain.BaseDirectory));
            CompositionContainer container = new CompositionContainer(catalog);
            container.ComposeParts(this);
             

        }
        //public IEnumerable<IContract> GetComponets()
        //{
        //    var x = Imports.Where(l => l.Metadata.JobType == JobType.Collection && l.Metadata.BrandName == BrandName.BrandY)
        //                   .Select(l => l.Value);

        //    return x;
                    
        //}       
    }
}
