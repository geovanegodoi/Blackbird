using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Blackbird.Domain.Entities;
using Blackbird.Domain.Repositories;
using Blackbird.Persistence.Context;

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
