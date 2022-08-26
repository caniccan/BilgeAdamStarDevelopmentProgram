using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro02.Console01.ISP
{
    class KargoDetay:Kargo
    {
        public string Detay { get; set; }
        //public override string KargoAdi { 
        //    get => base.KargoAdi;
        //    set => base.KargoAdi = value; }

        public override void AdresGetir()
        {
            
        }

        public override string Deneme()
        {
            return "bidi";
        }
    }
}
