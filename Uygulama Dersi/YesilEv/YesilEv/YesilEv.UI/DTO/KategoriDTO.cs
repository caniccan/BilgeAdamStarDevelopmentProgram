using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YesilEv.UI.DTO
{
    public class KategoriDTO
    {
        public int ID { get; set; }
        public string KategoriAdi { get; set; }

        public virtual Urun Urun { get; set; }
    }
}
