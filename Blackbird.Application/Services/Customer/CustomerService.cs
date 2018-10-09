using System;
using Blackbird.Application.TO;
using Blackbird.Domain.Entities;
using Blackbird.Domain.Repositories;

namespace Blackbird.Application.Services
{
    public class CustomerService 
        : CrudAppServiceBase<Guid, CustomerTO, ICustomerRepository, Customer>, ICustomerService
    {
        public CustomerService(ICustomerRepository repository) 
            : base(repository)
        {

        }
    }
}