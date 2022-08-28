using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YesilEvV2.Core.Entities;
using YesilEvV2.DAL;

namespace YesilEvV2.Mapping
{
    public class UyeMapping
    {
        public static Uye UyeEkleDTOtoUye(UyeEkleDTO uyeEkleDTO)
        {
            return new Uye()
            {
                ID = uyeEkleDTO.ID,
                AdSoyad = uyeEkleDTO.AdSoyad,
                TelNo = uyeEkleDTO.TelNo,
                KullaniciAdi = uyeEkleDTO.KullaniciAdi,
                Sifre = uyeEkleDTO.Sifre
            };
        }

    }
    
}
