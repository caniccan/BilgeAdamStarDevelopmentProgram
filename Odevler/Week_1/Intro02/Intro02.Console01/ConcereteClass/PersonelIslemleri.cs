using Intro02.Console01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro02.Console01.ConcereteClass
{
    public class PersonelIslemleri
    {
        Logger logger;
        public PersonelIslemleri()
        {
            logger = new Logger();
        }
        string logBilgisi;
        public bool AddPersonel(Personel per)
        {
            StringBuilder sb = new StringBuilder();
            try
            {

                sb.Append(per.AdSoyad);
                sb.AppendLine();
                sb.Append(per.TC);
                logBilgisi = logger.BuildLog(sb.ToString());
                logger.LogFile(@"C:\inetpub\MyLogs\Personellerim.txt", logBilgisi);

                sb = new StringBuilder();
                sb.Append(per.TC + "  nolu personel ekleme tarihi : ");
                sb.AppendLine();
                sb.Append(DateTime.Now.ToString());
                logBilgisi = logger.BuildLog(sb.ToString());
                logger.LogFile(@"C:\inetpub\MyLogs\PersonelLOG.txt", logBilgisi);
                return true;
            }
            catch (Exception ex)
            {
                sb = new StringBuilder();

                sb.Append(per.TC + "   hata tarihi ");
                sb.AppendLine();
                sb.Append(DateTime.Now.ToString());
                sb.AppendLine();
                sb.Append("Hata Mesajı : " + ex.Message);
                logBilgisi = logger.BuildLog(sb.ToString());
                logger.LogFile(@"C:\inetpub\MyLogs\PersonelLOG.txt", logBilgisi);
                return false;
            }



        }
    }
}
