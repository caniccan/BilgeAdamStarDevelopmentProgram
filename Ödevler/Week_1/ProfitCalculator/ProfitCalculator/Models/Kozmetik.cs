﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfitCalculator.Models
{
    public class Kozmetik : SatisFiyatiHesapla
    {
        public override double SatisFiyati(double alisFiyati)
        {
            return alisFiyati * 1.5;
        }
    }
}
