using System;
using Blackbird.Domain.Entities;
using Blackbird.Domain.Repositories;
using Blackbird.Persistence.ORM;

namespace Blackbird.Persistence.Repositories
{
    public class PurchaseRepository 
        : RepositoryAsyncBase<Guid, Purchase>, IPurchaseRepository
    {
        public PurchaseRepository(BlackbirdDbContext context)
        {

        }
    }
}
