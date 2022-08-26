using MyEFSample.UI.DAL.IRepo;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEFSample.UI.DAL.Repo
{
    public class Repo<T> : IRepo<T> where T : class
    {
        private readonly NorthwindEntities db = null;
        private readonly DbSet<T> tablo = null;
        public Repo()
        {
            db= new NorthwindEntities();
            tablo = db.Set<T>();
        }
        public int Delete(object ID)
        {
            T silinecekVeri = tablo.Find(ID);
            tablo.Remove(silinecekVeri);
            return db.SaveChanges();
        }
        public T Insert(T eklenecekVeri)
        {
            T eklenmisVeri = tablo.Add(eklenecekVeri);
            db.SaveChanges();
            return eklenmisVeri;
        }
        public List<T> Select()
        {
            return tablo.ToList();
        }
        public int Update(T guncellenecekVeri)
        {
            tablo.Attach(guncellenecekVeri);
            db.Entry(guncellenecekVeri).State = EntityState.Modified;
            return db.SaveChanges();
        }
    }
}
