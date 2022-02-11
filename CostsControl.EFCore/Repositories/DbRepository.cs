using CostsControl.EFCore.Context;
using CostsControl.EFCore.Entities.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CostsControl.EFCore.Repositories
{
    public class DbRepository<TEntity> : IRepository<TEntity> where TEntity: Entity, new()
    {
        private readonly CostsDB _db;
        private readonly DbSet<TEntity> _set;

        public DbRepository(CostsDB db)
        { 
            _db = db;
            _set = db.Set<TEntity>();
        }

        public virtual IQueryable<TEntity> ItemsInDataBase => _set;
        public virtual IQueryable<TEntity> ItemsInMemory => _set.Local.AsQueryable();

        public TEntity Add(TEntity entity)
        {
            if (entity is null)
                throw new ArgumentNullException(nameof(entity));

            _db.Entry(entity).State = EntityState.Added;

            _db.SaveChanges();

            return entity;
        }

        public async Task<TEntity> AddAsync(TEntity entity, CancellationToken Cancel = default)
        {
            if (entity is null)
                throw new ArgumentNullException(nameof(entity));

            _db.Entry(entity).State = EntityState.Added;

            await _db.SaveChangesAsync(Cancel).ConfigureAwait(false);

            return entity;
        }

        public TEntity Get(int id)
        {
            return ItemsInDataBase.SingleOrDefault(e => e.Id == id);
        }

        public async Task<TEntity> GetAsync(int id, CancellationToken Cancel = default)
        {
            return await ItemsInDataBase.SingleOrDefaultAsync(e => e.Id == id, Cancel).ConfigureAwait(false);
        }

        public void Remove(int id)
        {
            var entity = ItemsInMemory.FirstOrDefault(e => e.Id == id) ?? new TEntity { Id = id };

            _db.Remove(entity);

            _db.SaveChanges();
        }

        public async Task RemoveAsync(int id, CancellationToken Cancel = default)
        {
            var entity = ItemsInMemory.FirstOrDefault(e => e.Id == id) ?? new TEntity { Id = id };

            _db.Remove(entity);

            await _db.SaveChangesAsync(Cancel).ConfigureAwait(false);
        }

        public void Update(TEntity entity)
        {
            if (entity is null)
                throw new ArgumentNullException(nameof(entity));

            _db.Entry(entity).State = EntityState.Modified;

            _db.SaveChanges();
        }

        public async Task UpdateAsync(TEntity entity, CancellationToken Cancel = default)
        {
            if (entity is null)
                throw new ArgumentNullException(nameof(entity));

            _db.Entry(entity).State = EntityState.Modified;

            await _db.SaveChangesAsync(Cancel).ConfigureAwait(false);
        }
    }
}
