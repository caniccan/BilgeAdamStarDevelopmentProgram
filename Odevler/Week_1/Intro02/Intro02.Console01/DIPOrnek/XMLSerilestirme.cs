using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro02.Console01.DIPOrnek
{
    class XMLSerilestirme : ISeriazable
    {
        public void Deseriazable(string str)
        {
            //
            Console.WriteLine("veriyi xml ile deserilize ettik");
        }

        public void Seriazable(string str)
        {
            //
            Console.WriteLine("veriyi xml ile serilize ettik");
        }
    }
}
