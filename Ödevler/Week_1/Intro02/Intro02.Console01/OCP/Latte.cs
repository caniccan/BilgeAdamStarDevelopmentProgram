﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro02.Console01.OCP
{
    class Latte : Kahve
    {
        public override double Fiyat(double miktar)
        {
            return (miktar * 5)+2.5;
        }
    }
}
