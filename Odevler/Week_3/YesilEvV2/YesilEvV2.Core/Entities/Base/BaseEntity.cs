using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YesilEvV2.Core.Entities
{
    public class BaseEntity
    {
        public bool? AktifMi { get; set; } = false;
        public DateTime? OlusturulmaTarihi { get; set; }=DateTime.Now;
        public DateTime? DegistirilmeTarihi { get; set; }= DateTime.Now;
        public int? OluşturanKisi { get; set; }
        public int? DegistirenKisi { get; set; }
    }
}
