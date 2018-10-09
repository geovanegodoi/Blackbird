using System;
using Blackbird.Application.TO;
using Blackbird.Domain.Repositories;

namespace Blackbird.Application.Services
{
    public interface IProductService : ICrudAppService<Guid, ProductTO>
    {

    }
}
