using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro02.Console01.DIPOrnek
{
    class BinarySerialization : ISeriazable
    {
        public void Deseriazable(string str)
        {
            Console.WriteLine("veriyi binary ile deserilize ettik");
        }

        public void Seriazable(string str)
        {
            Console.WriteLine("veriyi binary ile serilize ettik");
        }
    }
}
