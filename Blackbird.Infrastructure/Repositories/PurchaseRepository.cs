using System;
using Blackbird.Domain.Entities;
using Blackbird.Domain.Repositories;
using Blackbird.Infrastructure.ORM;

namespace Blackbird.Infrastructure.Repositories
{
    public class PurchaseRepository : 
        RepositoryAsyncBase<Guid, Purchase>, IPurchaseRepository<Guid, Purchase>
    {
        public PurchaseRepository(BlackbirdDbContext context)
            : base(context)
        {

        }
    }
}
