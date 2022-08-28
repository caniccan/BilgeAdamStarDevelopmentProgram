using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YesilEvV2.Core.Entities
{
    [Table("UrunIcerik")]
    public class UrunIcerik:BaseEntity
    {
        [Key]
        public int ID { get; set; }
        public Urun UrunID { get; set; }
        public string MaddeAdi { get; set; }
        public int MaddeYuzde { get; set; }
        public bool TehlikeliMi { get; set; }
    }
}
