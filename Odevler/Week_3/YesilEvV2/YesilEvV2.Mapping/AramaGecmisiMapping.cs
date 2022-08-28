using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YesilEvV2.Core.Entities;
using YesilEvV2.DTOs;

namespace YesilEvV2.Mapping
{
    public class AramaGecmisiMapping
    {
        public static AramaGecmisi AramaGecmisiEkleDTOtoAramaGecmisi(AramaGecmisiEkleDTO aramaGecmisiEkleDTO)
        {
            return new AramaGecmisi()
            {
                ID= aramaGecmisiEkleDTO.ID,
                AramaIcerik=aramaGecmisiEkleDTO.AramaIcerik,
                UyeID=aramaGecmisiEkleDTO.UyeID,
                

            };
        }
    }
}
