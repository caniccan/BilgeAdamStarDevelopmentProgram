using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YesilEvV2.Core.Entities
{
    [Table("Favoriler")]
    public class Favoriler : BaseEntity
    {
        [Key]
        public int ID { get; set; }
        public FavoriListe FavoriListeID { get; set; }
        public List<Urun> uruns { get; set; }

        public override string ToString()
        {
            return ID.ToString();
        }
    }
}
