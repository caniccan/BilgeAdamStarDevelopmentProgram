using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YesilEvV2.Core.Entities
{
    [Table("AlerjikMadde")]
    public class AlerjikMadde:BaseEntity
    {
        [Key]
        public int ID { get; set; }
        public string AlerjikMaddeAdi { get; set; }
    }
}
