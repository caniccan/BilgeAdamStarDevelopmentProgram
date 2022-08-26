using ProfitCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfitCalculator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Urun> urunListesi = new List<Urun>();
            while (true)
            {
                Console.WriteLine("Ürün girişi yapmak için (giriş) / hesaplama yapmak için (hesapla) yazınız... ");
                //string girilenDeger=Console.ReadLine();
                if (Console.ReadLine().ToLower() != "hesapla")
                {
                    try
                    {
                        Urun urun = new Urun();
                        Console.WriteLine("Ürün Adı Giriniz...");
                        urun.UrunAdi = Console.ReadLine();
                        Console.WriteLine("Alış Fiyatı Giriniz ($)...");
                        urun.AlisFiyati = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ürün girişi yapmak istediğiniz kategoriyi giriniz... (Giyim), (Kozmetik) veya (Elektronik)");
                        urun.Kategori = Console.ReadLine().ToLower();
                        if (urun.Kategori=="giyim")
                        {
                            Giyim giyim=new Giyim();
                            urun.SatisFiyati = giyim.SatisFiyati(urun.AlisFiyati);
                        }
                        else if (urun.Kategori == "elektronik")
                        {
                            Elektronik _elektronik = new Elektronik();
                            urun.SatisFiyati = _elektronik.SatisFiyati(urun.AlisFiyati);
                        }
                        else if (urun.Kategori == "kozmetik")
                        {
                            Kozmetik _kozmetik = new Kozmetik();
                            urun.SatisFiyati = _kozmetik.SatisFiyati(urun.AlisFiyati);
                        }
                        urunListesi.Add(urun);
                        Console.WriteLine("Ürünün girişi başarıyla tamamlandı sonuçları görmek için (hesapla) bölümüne gidiniz...");
                    }
                    catch (FormatException fex)
                    {
                        Console.WriteLine(fex.Message);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Hatalı giriş...");
                    }
                }
                else
                {
                    if (urunListesi.Count>0 && urunListesi.Count<10000)
                    {
                        Console.WriteLine($"Listede Toplam {urunListesi.Count} adet ürün bulunmaktadır...");
                        Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");
                        foreach (var item in urunListesi)
                        {
                            Console.WriteLine($"Ürün Adı: {item.UrunAdi}");
                            Console.WriteLine($"Ürün Kategorisi: {item.Kategori}");
                            Console.WriteLine($"Ürün Alış Fiyatı: {item.AlisFiyati}");
                            Console.WriteLine($"Ürün Satış Fiyatı: {item.SatisFiyati}");
                            Console.WriteLine("-----------------------------------------------");
                            //Console.WriteLine($"Ürün Adı: {item.UrunAdi}, Ürün Kategorisi: {item.Kategori}, Ürün Alış Fiyatı: {item.AlisFiyati}, Ürün Satış Fiyatı: {item.SatisFiyati}$");

                        }
                        Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
                        Console.WriteLine("Programdan çıkmak için (bitir) / Ürün eklemeye devam etmek için (ekle) yazın ");
                        if (Console.ReadLine().ToLower()=="bitir")
                        {
                            Console.WriteLine("Program Sonlandırıldı...");
                            break;
                        }
                        
                    }
                    else
                    {
                        Console.WriteLine("Yeterli Giriş Yapılmadı...");
                    }
                }
            }
            Console.ReadKey();
        }

        
    }
}
