using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YesilEvV2.Core.Entities;
using YesilEvV2.DTOs;

namespace YesilEvV2.Mapping
{
    public class FavoriMapping
    {
        public static Favoriler FavoriEkleDTOtoFavoriler(FavoriEkleDTO favoriEkleDTO)
        {
            return new Favoriler()
            {
               ID=favoriEkleDTO.ID,
               FavoriListeID=favoriEkleDTO.FavoriListeID,
               uruns=favoriEkleDTO.uruns

            };
        }
    }
}
