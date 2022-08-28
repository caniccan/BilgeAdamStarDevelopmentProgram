using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YesilEvV2.Core.Entities
{
    [Table("YorumPuan")]
    public class YorumPuan:BaseEntity
    {
        [Key]
        public int ID { get; set; }
        public YorumOnay YorumOnayID { get; set; }
        public Puan PuanID { get; set; }
    }
}
