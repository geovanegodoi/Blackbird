using System;
using Blackbird.Application.TO;
using Blackbird.Domain.Entities;
using Blackbird.Domain.Repositories;

namespace Blackbird.Application.Services
{
    public class PurchaseService 
        : CrudAppServiceBase<Guid, PurchaseTO, IPurchaseRepository, Purchase>, IPurchaseService
    {
        public PurchaseService(IPurchaseRepository repository) 
            : base(repository)
        {

        }
    }
}
