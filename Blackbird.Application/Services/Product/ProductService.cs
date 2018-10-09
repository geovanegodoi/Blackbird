using System;
using Blackbird.Application.TO;
using Blackbird.Domain.Entities;
using Blackbird.Domain.Repositories;

namespace Blackbird.Application.Services
{
    public class ProductService
        : CrudAppServiceBase<Guid, ProductTO, IProductRepository, Product>, IProductService
    {
        public ProductService(IProductRepository repository) 
            : base(repository)
        {

        }
    }
}
