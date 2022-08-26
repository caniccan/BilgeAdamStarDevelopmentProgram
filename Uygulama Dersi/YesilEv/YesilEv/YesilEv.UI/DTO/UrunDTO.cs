using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YesilEv.UI.DTO
{
    public class UrunDTO
    {
        public int ID { get; set; }
        public string BarkodNo { get; set; }
        public Nullable<int> UreticiID { get; set; }
        public string UrunAdi { get; set; }
        public Nullable<int> KategoriID { get; set; }
        public string UrunIcerik { get; set; }
        public string OnYuz { get; set; }
        public string ArkaYuz { get; set; }
        public string TakipNo { get; set; }
        public Nullable<bool> DuzenlendiMi { get; set; }
        public Nullable<int> UyeID { get; set; }
    }
}
