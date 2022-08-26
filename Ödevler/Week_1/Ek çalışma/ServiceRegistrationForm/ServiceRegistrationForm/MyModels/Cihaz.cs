using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceRegistrationForm.MyModels
{
    public class Cihaz
    {
        public Musteri CihazSahibi { get; set; }
        public string CihazAd { get; set; }
        public string CihazModel { get; set; }
        public string CihazAriza { get; set; } = "Arızası yok";

        public override string ToString()
        {
            return $"Ad Soyad: {CihazSahibi.MusteriAdSoyad} Tc Kimlik No: {CihazSahibi.MusteriTCKimlikNo} Mail: {CihazSahibi.MusteriMail} Tel No:{CihazSahibi.MusteriTelNo} Adres:{CihazSahibi.MusteriAdres} Cihaz: {CihazAd} Model: {CihazModel} Arıza:{CihazAriza} Tarih: {DateTime.Now.ToString()}";
        }


    }
}
