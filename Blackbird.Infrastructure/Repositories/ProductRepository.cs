using System;
using Blackbird.Domain.Entities;
using Blackbird.Domain.Repositories;
using Blackbird.Infrastructure.ORM;

namespace Blackbird.Infrastructure.Repositories
{
    public class ProductRepository : 
        RepositoryAsyncBase<Guid, Product>, IProductRepository<Guid, Product>
    {
        public ProductRepository(BlackbirdDbContext context)
            : base(context)
        {

        }
    }
}
