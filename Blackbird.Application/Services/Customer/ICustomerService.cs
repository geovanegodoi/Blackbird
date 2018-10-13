using System;
using Blackbird.Application.TO;

namespace Blackbird.Application.Services
{
    public interface ICustomerService : ICrudAppService<Guid, CustomerTO>
    {

    }
}
