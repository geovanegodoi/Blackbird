using System;
using Blackbird.Domain.Entities;
using Blackbird.Domain.Repositories;
using Blackbird.Infrastructure.ORM;

namespace Blackbird.Infrastructure.Repositories
{
    public class PersonRepository : 
        RepositoryAsyncBase<Guid, Person>, IPersonRepository<Guid, Person>
    {
        public PersonRepository(BlackbirdDbContext context)
            : base(context)
        {

        }
    }
}
