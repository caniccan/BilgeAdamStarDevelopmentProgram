using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro02.Console01.OCP.OlmamasiGereken
{
    public enum KahveCesidi
    { 
    Latte,
    Espresso,
    Americano,
    TurkKahvesi
    }
    class KotuKahveOrnegi
    {
        public double KahveFiyatiHesapla(double miktar,KahveCesidi cesit)
        {
            double fiyat = 0;
            switch (cesit)
            {
                case KahveCesidi.Latte:
                    fiyat = miktar * 8;
                    break;
                case KahveCesidi.Espresso:
                    fiyat = miktar * 12.5;
                    break;
                case KahveCesidi.Americano:
                    fiyat = miktar * 10;
                    break;
                case KahveCesidi.TurkKahvesi:
                    fiyat = miktar * 5;
                    break;
                default:
                    break;
            }
            return fiyat;
        }
    }
}
