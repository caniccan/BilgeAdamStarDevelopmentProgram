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
    public class FavorListeDAL : EFRepoBase<MyDbContext, FavoriListe>, IFavorListeDAL
    {
        public FavorListeDAL()
        {

        }
        public FavorListeDAL(MyDbContext context) : base(context)
        {

        }

        public List<FavoriListe> favoriListeGetir()
        {
            return GetAll().ToList();
        }
    }
}
