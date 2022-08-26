using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDPMySample.Core
{
  public  class Urun:ClassBase
    {
        public string UrunAdi { get; set; }
        public Tedarikci Ureticisi { get; set; }
        public Kategori Kategori { get; set; }
        public decimal Fiyat { get; set; }
        public short StokMiktari { get; set; }

        public override string ToString()
        {
            return UrunAdi;
        }
    }
}
