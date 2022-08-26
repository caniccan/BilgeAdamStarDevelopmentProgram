using Intro02.Console01.Models;
using Intro02.Console01.OCP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Intro02.Console01.DIP.OlmasiGereken;
using Intro02.Console01.DIPOrnek;
using Intro02.Console01.ISP;
using Intro02.Console01.ISP.Dogrusu;

namespace Intro02.Console01
{
    class Program
    {
        static void Main(string[] args)
        {
            BadRepo<Kargo> islemler = new BadRepo<Kargo>();
            //islemler.Add(new Kargo()
            //{
            //    ID = "ABC",
            //    KargoAdi="asdasdasd"
            //});


            MyRepo<Kargo> ekle = new MyRepo<Kargo>();
            ekle.Add(null);

            MyRepo02<Kargo> silme = new MyRepo02<Kargo>();
            silme.Delete(56);


            #region bir sınıfı Index li hale getirin .  Ienumerable
            //Kargo k = new Kargo();
            //k.ID = "";
            //k.KargoAdi = "";
            //Kargo[] he4de = new Kargo[0];

            //Kargo krn = new Kargo(); 

            //using (Kargo k = new Kargo())
            //{
            //    k.KargoAdi = "";
            //}


            KargoDetay dt = new KargoDetay();
            
            dt.ID = "";
            dt.KargoAdi = "";
            dt.Detay = "";
            dt.AdresGetir();
            dt.Deneme();
            Kargo k02 = new KargoDetay();
            

            #endregion


            #region DIP 
            //Serializer seri = new Serializer(new BinarySerialization());
            //seri.Serilestir("asıdjasdjaksjdkasjdkajsdkajsdkj");

            //Serializer serilestir = new Serializer(new BinarySerialization());
            //serilestir.DeserilizeEt("asdasdasdasdasdasdasdasdasdas"); 
            #endregion


            #region DIP Ornek
            // Bildirim b = new Bildirim(
            //     new List<IGonder>() { 
            //     new  SMS(),
            //     new Email()}
            //     );
            // b.BildirimGonder();

            // Bildirim bld = new Bildirim(new List<IGonder>() { new SMS()});
            //// bld.BildirimGonder(); 
            #endregion


            #region OCP
            //Latte l = new Latte();
            //double fiyatBilgisi = l.Fiyat(50);

            //Mocha m = new Mocha();
            //double yeniMochaFiyat = m.Fiyat(1);
            ////neden?
            //Kahve kahve = new Mocha();
            //kahve.Fiyat(50); 
            #endregion

            Personel[] personellerim = new Personel[0];
            //todo boşluk kod ve Bitti dısındaki girilebilinecek herlşşeyi kontrol et.              
            while (true)
            {
                // girilenDeger != "Bitti";
                Console.WriteLine("Kullanıcı Bilgilerini giriniz. Bitti/(Gir)  Kelimesini yazarsanız program sonlanacaktır..");
                string girilenDeger = Console.ReadLine();
                if (girilenDeger == "Bitti")
                {
                    break;
                }
                //kullanıcıdan bilgi al.. 
                //try
                try
                {
                    Array.Resize(ref personellerim, personellerim.Length + 1);
                    Personel p = new Personel();
                    Console.WriteLine("ad girin");
                    p.AdSoyad = Console.ReadLine();
                    Console.WriteLine("Tc giriniz.. ");
                    p.TC = Console.ReadLine();
                    personellerim[personellerim.Length - 1] = p;
                }
                catch (FormatException fex)
                {
                    Console.WriteLine(fex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("askdıaskdjaksd");
                }
            }
            if (personellerim.Length != 0)
            {
                //tüm calisanlari goster 

                foreach (Personel item in personellerim)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("listelenecek personel bilgisi bulunamadı ..");
            }
            Console.ReadKey();            
        }
    }
}
