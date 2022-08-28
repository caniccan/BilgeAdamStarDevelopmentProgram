using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YesilEvV2.Core.Entities
{
    [Table("Uretici")]
    public class Uretici : BaseEntity
    {
        [Key]
        public int ID { get; set; }
        public string UreticiAdi { get; set; }
        public string UreticiAdres { get; set; }
        public string UreticiTelNo { get; set; }
        public string UreticiMail { get; set; }
        public List<Urun> uruns { get; set; }

        public override string ToString()
        {
            return UreticiAdi;
        }

    }
}
