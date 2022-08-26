using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro02.Console01.DIP.Deneme
{
    //todo sdfsf
    class Bildirim
    {
        public Bildirim()
        {
            e = new Email();
        }
        Email e = null;
        SMS s = new SMS();
        public void Gonder()
        {
            e.MailAT();
            s.SMSAT();
        }

    }
}
