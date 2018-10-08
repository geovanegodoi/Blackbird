using System;
using Blackbird.Domain.Entities;
using Blackbird.Domain.Repositories;
using Blackbird.Infrastructure.ORM;

namespace Blackbird.Infrastructure.Repositories
{
    public class CustomerRepository : 
        RepositoryAsyncBase<Guid, Customer>, ICustomerRepository<Guid, Customer>
    {
        public CustomerRepository(BlackbirdDbContext context)
            : base(context)
        {

        }
    }
}
