using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YesilEvV2.Core.Entities;

namespace YesilEvV2.DTOs
{
    public class AramaGecmisiEkleDTO
    {
        public int ID { get; set; }
        public string AramaIcerik { get; set; }
        public Uye UyeID { get; set; }
    }
}
