using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.Hastane.MyModels
{
    public class Hasta
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string SecilenDoktor { get; set; }
        public string TC { get; set; }
        public string Sikayet { get; set; }
        public string Teshis { get; set; }
        public DateTime KayitTarihi { get; set; }

        public override string ToString()
        {
            return Ad;
        }
    }
}
