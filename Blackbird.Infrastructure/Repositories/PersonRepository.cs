﻿using System;
using Blackbird.Domain.Entities;
using Blackbird.Domain.Repositories;
using Blackbird.Infrastructure.ORM;

namespace Blackbird.Infrastructure.Repositories
{
    public class PersonRepository 
        : RepositoryAsyncBase<Guid, Person>, IPersonRepository
    {
        public PersonRepository(BlackbirdDbContext context)
            : base(context)
        {

        }
    }
}
