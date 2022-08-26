using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro02.Console01.DIPOrnek
{
    //Strategy DP
    class Serializer
    {
        ISeriazable srz;
        public Serializer(ISeriazable seriazable)
        {
            srz = seriazable;
        }

        public void Serilestir(string str)
        {
            srz.Seriazable(str);
        }
        public void DeserilizeEt(string str)
        {
            srz.Deseriazable(str);
        }

    }
}
