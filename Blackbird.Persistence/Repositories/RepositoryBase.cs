using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Blackbird.Domain.Entities;
using Blackbird.Domain.Repositories;
using Blackbird.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace Blackbird.Persistence.Repositories
{
    public abstract class RepositoryBase<TKey, TEntity> : 
        IRepository<TKey, TEntity>
        where TEntity : class, IEntity<TKey>
    {
        protected readonly BlackbirdDbContext _context;
        protected readonly DbSet<TEntity> _table;

        protected RepositoryBase()
        {
            _context = BlackbirdDbContext.CreateDbContext();
            _table = _context.Set<TEntity>();
        }

        public TEntity Get(TKey id)
        {
            return _table.Find(id);
        }

        public TEntity FirstOrDefault(Expression<Func<TEntity, bool>> predicate)
        {
            return _table.FirstOrDefault(predicate);
        }

        public IQueryable<TEntity> GetAll()
        {
            return _table;
        }

        public List<TEntity> GetAllList()
        {
            return _table.ToList();
        }

        public List<TEntity> GetAllList(Expression<Func<TEntity, bool>> predicate)
        {
            return _table.Where(predicate).ToList();
        }

        public TEntity Insert(TEntity entity)
        {
            _table.Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public TKey InsertAndGetId(TEntity entity)
        {
            _table.Add(entity);
            _context.SaveChanges();
            return entity.Id;
        }

        public TEntity Update(TEntity entity)
        {
            _table.Update(entity);
            _context.SaveChanges();
            return entity;
        }

        public void Delete(TEntity entity)
        {
            _table.Remove(entity);
            _context.SaveChanges();
        }

        public void Delete(TKey id)
        {
            var entity = _table.Find(id);
            _table.Remove(entity);
            _context.SaveChanges();
        }
    }
}
