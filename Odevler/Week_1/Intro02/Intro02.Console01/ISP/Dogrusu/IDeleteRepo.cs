using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro02.Console01.ISP.Dogrusu
{
    public interface IDeleteRepo<T>
    {
        void Delete(object ID);
    }
}
