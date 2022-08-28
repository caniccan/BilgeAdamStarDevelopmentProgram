using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YesilEvV2.Core.Context;
using YesilEvV2.Core.Entities;
using YesilEvV2.Core.Repos;
using YesilEvV2.DAL.Interfaces;

namespace YesilEvV2.DAL.Concrete
{
    public class KategoriDAL : EFRepoBase<MyDbContext, Kategori>, IKategoriDAL
    {
        public KategoriDAL()
        {

        }
        public KategoriDAL(MyDbContext context) : base(context)
        {

        }

        public int IdCevir(object name)
        {
            return 2;

        }

        public string KategoriCevir(Urun urun)
        {
            return GetByID(urun.kategoriID).KategoriAdi;
        }

        public List<Kategori> KategorileriGetir()
        {
            return GetAll().ToList();
        }
    }
}
