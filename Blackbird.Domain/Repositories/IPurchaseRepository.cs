using System;
using Blackbird.Domain.Entities;

namespace Blackbird.Domain.Repositories
{
    public interface IPurchaseRepository 
        : IRepository<Guid, Purchase>, IRepositoryAsync<Guid, Purchase>
    {

    }
}
