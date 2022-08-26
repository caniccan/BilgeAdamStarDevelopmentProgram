using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfitCalculator.Models
{
    public class Urun
    {
        public string UrunAdi { get; set; }
        string _kategori;
        public string Kategori 
        { 
            get { return _kategori; }
            set 
            { 
                _kategori = value;
                if (!(_kategori.ToLower()=="elektronik" || _kategori.ToLower() == "giyim" || _kategori.ToLower() == "kozmetik"))
                {
                    throw new FormatException("Yanlış kategori girişi yaptınız... Lütfen giyim,kozmetik veya elektronik kategorilerinden birini giriniz...");
                }    
            }
        }
        public double AlisFiyati { get; set; }
        public double SatisFiyati { get; set; }
    }
}
