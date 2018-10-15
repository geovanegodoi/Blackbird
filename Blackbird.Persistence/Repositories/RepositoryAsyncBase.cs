using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Blackbird.Commom.ExtendedTypes;
using Blackbird.Domain.Entities;
using Blackbird.Domain.Repositories;
using Blackbird.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace Blackbird.Persistence.Repositories
{
    public abstract class RepositoryAsyncBase<TKey, TEntity> : 
        RepositoryBase<TKey, TEntity>, 
        IRepositoryAsync<TKey, TEntity>
        where TEntity : class, IEntity<TKey>
    {
        protected RepositoryAsyncBase() : base()
        {

        }

        public async Task<TEntity> GetAsync(TKey id)
        {
            return await _table.FindAsync(id);
        }

        public async Task<TEntity> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await Task.Run(() => _table.FirstOrDefault(predicate));
        }

        public async Task<PaginatedList<TEntity>> GetAllAsync(PagingCriteria criteria)
        {
            return await PaginatedList<TEntity>.Create(_table, criteria);
        }

        public async Task<PaginatedList<TEntity>> GetAllAsync(PagingCriteria criteria, Expression<Func<TEntity, bool>> predicate)
        {
            return await PaginatedList<TEntity>.Create(_table.Where(predicate), criteria);
        }

        public async Task<TKey> InsertAndGetIdAsync(TEntity entity)
        {
            await _table.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity.Id;
        }

        public async Task<TEntity> InsertAsync(TEntity entity)
        {
            await _table.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            await Task.Run(() => _table.Update(entity));
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(TEntity entity)
        {
            await Task.Run(() => _table.Remove(entity));
        }

        public async Task DeleteAsync(TKey id)
        {
            var entity = await _table.FindAsync(id);

            await Task.Run(() => _table.Remove(entity));
        }
    }
}
