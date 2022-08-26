using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro02.Console01.ISP
{
 abstract  class Kargo:IDisposable
    {
        public  string ID { get; set; }
        public virtual string KargoAdi { get; set; }

        public abstract void AdresGetir();
        public virtual string Deneme()
        {
            return "hede";
        }
        public void Dispose()
        {
            //
         
        }
    }
}
