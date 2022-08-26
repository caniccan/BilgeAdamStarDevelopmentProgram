using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro02.Console01.ISP
{
 public interface IBadREpo<T> where T:class
    {
        void Add(T eklenecekVeri);

        void Update(T guncellencekVeri);

        void Delete(int ID);
    }
}
