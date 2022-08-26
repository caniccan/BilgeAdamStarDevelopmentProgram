using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro02.Console01.ISP.Dogrusu
{
    class MyRepo<T> : IAddRepo<T>
    {
        public void Add(T eklenecekVeri)
        {
          
        }
    }

    class MyRepo02<T> : IDeleteRepo<T>
    {
        public void Delete(object ID)
        {
            throw new NotImplementedException();
        }
    }



}
