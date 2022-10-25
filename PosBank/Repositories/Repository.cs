using PosBank.Models;
using PosBank.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PosBank.Repositories
{
    public class Repository<TEntity>: IRepository<TEntity> where TEntity :class
    {
        protected readonly PosbankDbContext _db;
        public Repository(PosbankDbContext db)
        {
            _db = db;
        }

        public TEntity Get(int id)
        {
            return _db.Set<TEntity>().Find(id);
        }

        public void Add(TEntity entity)
        {
            _db.Set<TEntity>().Add(entity);

            SaveAsync();
        }

        public void Remove(TEntity entity)
        {
            _db.Set<TEntity>().Remove(entity);
            SaveAsync();
        }


        public TEntity Find(int id)
        {
            var entity = _db.Set<TEntity>().Find(id);
            return entity;
        }

        public IList<TEntity> List()
        {
            return _db.Set<TEntity>().ToList();
        }

        public void Update(int id, TEntity entity)
        {
            _db.Set<TEntity>().Update(entity);
            SaveAsync();
        }

        public void UpdateRange(IEnumerable<TEntity> entities)
        {
            _db.Set<TEntity>().UpdateRange(entities);
            SaveAsync();
        }


        public void AddRange(IEnumerable<TEntity> entities)
        {
            _db.Set<TEntity>().AddRangeAsync(entities);

        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            _db.Set<TEntity>().RemoveRange(entities);
        }

        public void SaveAsync()
        {
            _db.SaveChanges();
        }


    }
}
