using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro02.Console01.OCP
{
    class Mocha : Kahve
    {
        public override double Fiyat(double miktar)
        {
            return miktar * 10;
        }
    }
}
