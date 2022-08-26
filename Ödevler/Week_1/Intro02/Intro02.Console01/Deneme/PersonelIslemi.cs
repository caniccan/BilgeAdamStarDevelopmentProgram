using Intro02.Console01.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro02.Console01.Deneme
{
    /// <summary>
    /// SOLID 
    /// </summary>
 public   class PersonelIslemi
    {

        public string PersonelEkle(Personel personel)
        {
            //nulluk kontrolu ?
            StringBuilder sb = new StringBuilder();
            try
            {                
                sb.Append(personel.AdSoyad);
                sb.AppendLine();
                sb.Append(personel.TC);

                File.WriteAllText(@"C:\inetpub\MyLogs\Personellerim.txt", sb.ToString());

                sb = new StringBuilder();

                sb.Append(personel.TC + "  nolu personel ekleme tarihi : ");
                sb.AppendLine();
                sb.Append(DateTime.Now.ToString());

                File.WriteAllText(@"C:\inetpub\MyLogs\PersonelLOG.txt", sb.ToString());
                return "personel başarıyla eklenmiştir... ";
              // Console.WriteLine("personel başarıyla eklenmiştir... ");

            }
            catch (Exception ex)
            {
                sb = new StringBuilder();

                sb.Append(personel.TC+"   hata tarihi ");
                sb.AppendLine();
                sb.Append(DateTime.Now.ToString());
                sb.AppendLine();
                sb.Append("Hata Mesajı : "+ ex.Message);


                File.WriteAllText(@"C:\inetpub\MyLogs\PersonelLOG.txt", sb.ToString());

                //  Console.WriteLine("hata oluştu...");
                return "hata oluştu...";
            }

        }

    }
}
