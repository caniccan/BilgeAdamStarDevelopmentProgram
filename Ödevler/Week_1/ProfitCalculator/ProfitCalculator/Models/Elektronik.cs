using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfitCalculator.Models
{
    public class Elektronik : SatisFiyatiHesapla
    {
        public override double SatisFiyati(double alisFiyati)
        {
            return alisFiyati * 2.5;
        }
    }
}
