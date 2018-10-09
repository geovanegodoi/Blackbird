using System;
using Blackbird.Domain.Entities;

namespace Blackbird.Domain.Repositories
{
    public interface IProductRepository 
        : IRepository<Guid, Product>, IRepositoryAsync<Guid, Product>
    {

    }
}
