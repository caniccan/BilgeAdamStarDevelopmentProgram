using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YesilEvV2.Core.Interfaces;

namespace YesilEvV2.Core.Repos
{
    public abstract class EFRepoBase<TContext, TEntity> :
        ISelectableRepo<TEntity>,
        IDeletetableRepo<TEntity>,
        IUpdatableRepo<TEntity>,
        IInsertableRepo<TEntity> where TEntity : class where TContext : DbContext, new()
    {
        private readonly TContext _context;
        public EFRepoBase(TContext context)
        {
            _context = context;
        }
        public EFRepoBase()
        {
            _context = new TContext();
        }
        public TEntity Add(TEntity item)
        {
            return _context.Set<TEntity>().Add(item);
        }

        public List<TEntity> AddRange(List<TEntity> items)
        {
            return _context.Set<TEntity>().AddRange(items).ToList();
        }

        public TEntity Delete(TEntity item)
        {
            return _context.Set<TEntity>().Remove(item);
        }

        public List<TEntity> GetAll()
        {
            return _context.Set<TEntity>().ToList();
        }

        public List<TEntity> GetBy(Func<TEntity, bool> whereCondition)
        {
            return _context.Set<TEntity>().Where(whereCondition).ToList();
        }

        public TEntity GetByID(object ID)
        {
            return _context.Set<TEntity>().Find(ID);
            ;
        }


        public void MySaveChanges()
        {
            _context.SaveChanges();
        }

        public bool MySaveChangesBackTF()
        {
            if (_context.SaveChanges() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Update(TEntity item)
        {
            _context.Entry(item).State = EntityState.Modified;
            _context.Set<TEntity>().Attach(item);
        }
    }
}
