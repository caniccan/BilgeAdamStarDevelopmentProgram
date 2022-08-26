using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YesilEv.UI.DTO;

namespace YesilEv.UI.Mapping
{
    public class Extension
    {
        public static Urun UrunDTOtoUrun(UrunDTO dto)
        {
            return new Urun()
            {
                ID=dto.ID,
                ArkaYuz=dto.ArkaYuz,
                BarkodNo=dto.BarkodNo,
                DuzenlendiMi=dto.DuzenlendiMi,
                KategoriID=dto.KategoriID,
                OnYuz=dto.OnYuz,
                UreticiID=dto.UreticiID,
                UrunAdi=dto.UrunAdi,
                UrunIcerik=dto.UrunIcerik,
                UyeID=dto.UyeID,
                TakipNo=dto.TakipNo,
            };
        }
        
    }
}
