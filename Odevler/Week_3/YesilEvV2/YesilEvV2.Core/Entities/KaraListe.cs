using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YesilEvV2.Core.Entities
{
    [Table("KaraListe")]
    public class KaraListe : BaseEntity
    {
        [Key]
        public int ID { get; set; }
        
        public List<Urun> UrunID { get; set; }
        public string EklemeSebebi { get; set; }
        public Hasta HastaID { get; set; }


    }
}
