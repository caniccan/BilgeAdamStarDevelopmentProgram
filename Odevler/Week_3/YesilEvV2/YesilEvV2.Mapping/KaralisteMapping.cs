using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YesilEvV2.Core.Entities;
using YesilEvV2.DTOs;

namespace YesilEvV2.Mapping
{
    public class KaralisteMapping
    {
        public static KaraListe FavoriEkleDTOtoFavoriler(KaralisteEkleDTO favoriEkleDTO)
        {
            return new KaraListe()
            {
                HastaID = favoriEkleDTO.HastaID,
                ID = favoriEkleDTO.ID,
                UrunID=favoriEkleDTO.UrunID,
                EklemeSebebi=favoriEkleDTO.EklemeSebebi,
                

            };
        }
    }
}
