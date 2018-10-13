using System;
using Blackbird.Domain.Entities;
using Blackbird.Domain.Repositories;
using Blackbird.Persistence.Context;

namespace Blackbird.Persistence.Repositories
{
    public class ProductRepository 
        : RepositoryAsyncBase<Guid, Product>, IProductRepository
    {
        public ProductRepository(BlackbirdDbContext context)
        {

        }
    }
}
