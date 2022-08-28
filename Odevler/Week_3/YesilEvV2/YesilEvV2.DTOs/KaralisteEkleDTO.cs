using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YesilEvV2.Core.Entities;

namespace YesilEvV2.DTOs
{
    public class KaralisteEkleDTO
    {
        public int ID { get; set; }

        public List<Urun> UrunID { get; set; }
        public string EklemeSebebi { get; set; }
        public Hasta HastaID { get; set; }

    }
}
