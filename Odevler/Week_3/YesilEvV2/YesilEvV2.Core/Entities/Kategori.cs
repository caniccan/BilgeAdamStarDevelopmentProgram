using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YesilEvV2.Core.Entities
{
    [Table("Kategori")]
    public class Kategori : BaseEntity
    {
        [Key]
        public int ID { get; set; }
        public string KategoriAdi { get; set; }
        public int UstKategoriID { get; set; }
        public List<Urun> Uruns { get; set; }

        public override string ToString()
        {
            return KategoriAdi;
        }

    }
}
