using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YesilEvV2.Core.Entities
{
    [Table("Urun")]
    public class Urun : BaseEntity
    {
        [Key]
        public int ID { get; set; }
        public string BarkodNo { get; set; }
        public Uretici UreticiID { get; set; }

        public Kategori kategoriID { get; set; }

        public string urunAdi { get; set; }
        public string urunIcerik { get; set; }
        public string OnYuz { get; set; }
        public string ArkaYuz { get; set; }
        public string TakipNo { get; set; }
        public bool? DuzenlendiMi { get; set; }
        public List<Duzenleme> duzenlemes { get; set; }
        public List<Favoriler> favorilers { get; set; }

        public override string ToString()
        {
            return this.urunAdi;
        }


    }
}
