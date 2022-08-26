using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro02.Console01.ISP
{
    class BadRepo<T> : IBadREpo<T> where T : class
    {
        public void Add(T eklenecekVeri)
        {
           
        }

        public void Delete(int ID)
        {
        }

        public void Update(T guncellencekVeri)
        {
            
        }
    }
}
