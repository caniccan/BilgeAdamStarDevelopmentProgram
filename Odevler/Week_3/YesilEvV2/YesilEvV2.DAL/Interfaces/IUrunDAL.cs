using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YesilEvV2.Core.Entities;

namespace YesilEvV2.DAL.Interfaces
{
    public interface IUrunDAL
    {
        List<Urun> UrunleriGetir();
        void UrunEkle(string barkodNo, object uretici, string urunAdi, object kategori, string urunIcerigi, string onYuz, string arkaYuz);
    }
}
