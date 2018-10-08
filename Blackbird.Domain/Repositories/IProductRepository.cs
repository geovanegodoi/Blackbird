using System;
using Blackbird.Domain.Entities;

namespace Blackbird.Domain.Repositories
{
    public interface IProductRepository<TKey, TEntity> : IRepository<TKey, TEntity>, IRepositoryAsync<TKey, TEntity>
        where TEntity : IEntity<TKey>
    {

    }
}
