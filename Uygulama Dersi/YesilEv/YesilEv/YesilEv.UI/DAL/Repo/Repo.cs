using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YesilEv.UI.DAL.IRepo;

namespace YesilEv.UI.DAL.Repo
{
    public class Repo<T> : IRepo<T> where T:class
    {
        private readonly YesilEvEntities db = null;
        private readonly DbSet<T> tablo=null;
        public Repo()
        {
            db = new YesilEvEntities();
            tablo = db.Set<T>();
        }



        public int Delete(object ID)
        {
            T eskiVeri = tablo.Find(ID);
            tablo.Remove(eskiVeri);
            return db.SaveChanges();
        }

        public T Insert(T eklenecekVeri)
        {
            T eklenmisData = tablo.Add(eklenecekVeri);
            db.SaveChanges();
            return eklenmisData;
        }

        public List<T> Select()
        {
            return tablo.ToList();
        }

        public List<T> SelectByFilter(System.Linq.Expressions.Expression<Func<T, bool>> filter)
        {
            return tablo.Where(filter).ToList();
        }

        public T SelectByID(object ID)
        {
            return tablo.Find(ID);
        }
        public int Update(T guncellenecekVeri)
        {
            tablo.Attach(guncellenecekVeri);
            db.Entry(guncellenecekVeri).State = EntityState.Modified;
            return db.SaveChanges();
        }
    }
}
