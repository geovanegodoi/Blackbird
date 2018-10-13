using System;
using Blackbird.Application.TO;

namespace Blackbird.Application.Services
{
    public interface IPersonService : ICrudAppService<Guid, PersonTO>
    {

    }
}