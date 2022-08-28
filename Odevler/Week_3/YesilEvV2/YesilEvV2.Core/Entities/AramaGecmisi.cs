using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YesilEvV2.Core.Entities
{
    [Table("AramaGecmisi")]
    public class AramaGecmisi:BaseEntity
    {
        [Key]
        public int ID { get; set; }
        public string AramaIcerik { get; set; }
        public Uye UyeID { get; set; }

        public override string ToString()
        {
            return AramaIcerik + "     " + OlusturulmaTarihi;
        }


    }
}
