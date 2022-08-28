using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YesilEvV2.Core.Context;
using YesilEvV2.Core.Entities;
using YesilEvV2.Core.Repos;
using YesilEvV2.DAL.Interfaces;
using YesilEvV2.DTOs;
using YesilEvV2.Mapping;

namespace YesilEvV2.DAL.Concrete
{
    public class FavorilerDAL : EFRepoBase<MyDbContext, Favoriler>, IFavorilerDAL
    {
        public FavorilerDAL()
        {

        }
        public FavorilerDAL(MyDbContext context) : base(context)
        {

        }

        public void FavoriEkle(object listItem)
        {
            List<Urun> favorilers = new List<Urun>();
            FavoriEkleDTO favoriEkleDTO = new FavoriEkleDTO()
            {
                ID = 0,
                //FavoriListeID = 1,
                uruns=favorilers

            };


            Add(FavoriMapping.FavoriEkleDTOtoFavoriler(favoriEkleDTO));
        }

        public List<Favoriler> Favoriler()
        {
           return GetAll().ToList();
        }
    }
}
