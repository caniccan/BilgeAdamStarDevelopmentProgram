using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro02.Console01.DIPOrnek
{
    public interface ISeriazable
    {
        void Seriazable(string str);
        void Deseriazable(string str);
    }
}
