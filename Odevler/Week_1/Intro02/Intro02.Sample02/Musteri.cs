using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro02.Sample02
{
    public abstract class Musteri
    {
        public string MusteriTanimi { get; set; }
        public decimal Bakiye { get; set; }
        public string HesapNo { get; set; }

        public void ParaCek(decimal miktar)
        {

        }
        public void ParaYatir(decimal miktar) { }
        public abstract void KrediCek(decimal krediMiktari, decimal maas);

    }
}
