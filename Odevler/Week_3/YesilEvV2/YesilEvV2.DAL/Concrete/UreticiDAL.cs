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
    public class UreticiDAL : EFRepoBase<MyDbContext, Uretici>, IUreticiDAL
    {
        public UreticiDAL()
        {

        }
        public UreticiDAL(MyDbContext context):base(context)
        {

        }

        public int IdCevir(object name)
        {
            return 1;
        }

        public string UreticiCevir(Urun urun)
        {
            return GetByID(urun.UreticiID).UreticiAdi;
        }

        public List<Uretici> UreticiGetir()
        {
            return GetAll().ToList();
        }
    }
}
