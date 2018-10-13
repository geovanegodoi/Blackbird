using System;
using Blackbird.Application.TO;

namespace Blackbird.Application.Services
{
    public interface IProductService : ICrudAppService<Guid, ProductTO>
    {

    }
}
