using System;
using Blackbird.Domain.Entities;

namespace Blackbird.Domain.Repositories
{
    public interface IPersonRepository 
        : IRepository<Guid, Person>, IRepositoryAsync<Guid, Person>
    {
    }
}
