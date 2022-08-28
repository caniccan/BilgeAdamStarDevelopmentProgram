using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YesilEvV2.Core.Context;
using YesilEvV2.Core.Entities;
using YesilEvV2.Core.Repos;
using YesilEvV2.DAL.Concrete;
using YesilEvV2.DAL.Interfaces;
using YesilEvV2.Mapping;

namespace YesilEvV2.DAL
{
    public class UrunDAL: EFRepoBase<MyDbContext, Urun>, IUrunDAL
    {
        public UrunDAL()
        {

        }
        public UrunDAL(MyDbContext context):base(context)
        {
            
        }

        public void UrunEkle(string barkodNo,object uretici,string urunAdi,object kategori,string urunIcerigi, string onYuz,string arkaYuz)
        {
            UreticiDAL ureticiDAL = new UreticiDAL();
            KategoriDAL kategoriDAL = new KategoriDAL();
            var a= ureticiDAL.GetBy(x=>x.UreticiAdi==uretici.ToString()).FirstOrDefault();

            var b = kategoriDAL.GetBy(x => x.KategoriAdi == kategori.ToString()).FirstOrDefault();
            UrunEkleDTO urunEkleDTO = new UrunEkleDTO()
            {
                ID = 0,
                urunAdi = urunAdi,
                UreticiID = a,
                BarkodNo = barkodNo,
                kategoriID = b,
                OnYuz = onYuz,
                ArkaYuz = arkaYuz,
                urunIcerik = urunIcerigi,
                TakipNo = null

            };
            Add(UrunMapping.UrunEkleDTOtoUrun(urunEkleDTO));
        }

        public List<Urun> UrunleriGetir()
        {

            return GetAll().ToList();

            


        }
    }
}
