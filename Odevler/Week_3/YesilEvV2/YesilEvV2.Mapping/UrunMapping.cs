using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YesilEvV2.Core.Entities;
using YesilEvV2.DAL;

namespace YesilEvV2.Mapping
{
    public class UrunMapping
    {
        public static Urun UrunEkleDTOtoUrun(UrunEkleDTO urunEkleDTO)
        {
            return new Urun()
            {
                ID = urunEkleDTO.ID,
                ArkaYuz= urunEkleDTO.ArkaYuz,
                OnYuz= urunEkleDTO.OnYuz,
                kategoriID= urunEkleDTO.kategoriID,
                UreticiID= urunEkleDTO.UreticiID,
                urunIcerik= urunEkleDTO.urunIcerik,
                BarkodNo= urunEkleDTO.BarkodNo,
                urunAdi= urunEkleDTO.urunAdi,
                TakipNo= urunEkleDTO.TakipNo,
                
            };
        }
    }
}
