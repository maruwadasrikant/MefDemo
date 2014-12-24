using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mef.Demo.Contracts
{
    //public interface ISearchEngine<in TQuery, out TResult>
    //{
    //    IEnumerable<TResult> Search(TQuery query);
    //}

    public interface ISearchEngine
    {
        void Search();
    }
}
