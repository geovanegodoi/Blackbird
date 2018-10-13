using System;
using Blackbird.Commom.IoC;
using Blackbird.Domain.Entities;

namespace Blackbird.Domain.Repositories
{
    public interface ICustomerRepository 
        : IRepository<Guid, Customer>, IRepositoryAsync<Guid, Customer>
    {
    }
}
