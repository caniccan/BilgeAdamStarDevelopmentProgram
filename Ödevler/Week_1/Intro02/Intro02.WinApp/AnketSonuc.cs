using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro02.WinApp
{
 public   class AnketSonuc
    {
        public AnketSonuc()
        {
            AnketSonuclari = new List<bool>();
        }
        public DateTime Tarih { get; set; }
        public List<bool> AnketSonuclari { get; set; }
    }
}
