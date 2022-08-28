using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YesilEvV2.Core.Entities
{
    [Table("Hasta")]
    public class Hasta
    {
        [Key]
        public int ID { get; set; }
        public string HastaAdSoyad { get; set; }
        public List<AlerjikMadde> AlerjikMaddeID { get; set; }
    }
}
