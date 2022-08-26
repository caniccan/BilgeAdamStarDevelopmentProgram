using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceRegistrationForm
{
    public class Musteri
    {
        public string MusteriAdSoyad { get; set; }
        public string MusteriTelNo { get; set; }
        public string MusteriMail { get; set; }
        public string MusteriAdres { get; set; }
        public string MusteriTCKimlikNo { get; set; }

        public override string ToString()
        {
            return $"Ad Soyad: {MusteriAdSoyad} Tel No: {MusteriTelNo} Mail: {MusteriMail} Adres: {MusteriAdres} TC: {MusteriTCKimlikNo}";
        }

    }
}
