using System;
using Blackbird.Application.TO;
using Blackbird.Domain.Entities;
using Blackbird.Domain.Repositories;

namespace Blackbird.Application.Services
{
    public class PersonService 
        : CrudAppServiceBase<Guid, PersonTO, IPersonRepository, Person>, IPersonService
    {
        public PersonService(IPersonRepository repository) 
            : base(repository)
        {

        }
    }
}