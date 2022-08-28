using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YesilEvV2.Core.Entities;

namespace YesilEvV2.DAL.Interfaces
{
    public interface IFavorListeDAL
    {
        List<FavoriListe> favoriListeGetir();
    }
}
