using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro02.Console01.Models
{
   public class Personel
    {
        //string isim;
        //string tc;

        public string AdSoyad { get; set; }


        string _TC;
        public string TC
        {
            get {
                return _TC;
            }
            set {
                _TC = value;

                if (!(_TC.Length == 11 && (_TC[0] != '0')) /*tc algoritmasını işlet..*/)
                {
                    throw new FormatException("ilk karakter 0 olmamalı ve ya 11 karakter veri girmelisiniz.. ");
                }
            }
        }

        public override string ToString()
        {
            return AdSoyad + " " + TC;
        }

    }
}
