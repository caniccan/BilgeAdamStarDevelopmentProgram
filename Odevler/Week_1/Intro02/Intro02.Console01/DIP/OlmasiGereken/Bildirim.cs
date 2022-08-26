using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro02.Console01.DIP.OlmasiGereken
{
    class Bildirim
    {
        List<IGonder> _gonderilecekMesajlar;
        public Bildirim(List<IGonder> gonderilecekMesajlar)
        {
            _gonderilecekMesajlar = gonderilecekMesajlar;

        }

        public void BildirimGonder()
        {
            foreach (var item in _gonderilecekMesajlar)
            {
                item.Gonder();

            }
        
        }

    }
}
