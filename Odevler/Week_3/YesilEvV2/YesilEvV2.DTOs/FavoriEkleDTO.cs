using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YesilEvV2.Core.Entities;

namespace YesilEvV2.DTOs
{
    public class FavoriEkleDTO
    {
        public int ID { get; set; }
        public FavoriListe FavoriListeID { get; set; }
        public List<Urun> uruns { get; set; }
    }
}
