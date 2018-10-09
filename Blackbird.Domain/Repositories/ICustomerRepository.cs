using System;
using Blackbird.Domain.Entities;

namespace Blackbird.Domain.Repositories
{
    public interface ICustomerRepository 
        : IRepository<Guid, Customer>, IRepositoryAsync<Guid, Customer>
    {
    }
}
