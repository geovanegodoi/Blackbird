using System;
using Blackbird.Domain.Entities;
using Blackbird.Domain.Repositories;

namespace Blackbird.Persistence.Repositories
{
    public class CustomerRepository 
        : RepositoryAsyncBase<Guid, Customer>, ICustomerRepository
    {
        public CustomerRepository()
        {

        }
    }
}
