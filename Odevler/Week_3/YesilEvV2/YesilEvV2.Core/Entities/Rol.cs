using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YesilEvV2.Core.Entities
{
    [Table("Rol")]
    public class Rol : BaseEntity
    {
        [Key]
        public int ID { get; set; }
        public string RolAdi { get; set; }
        public RolYetki RolYetkiID { get; set; }
        


    }
}
