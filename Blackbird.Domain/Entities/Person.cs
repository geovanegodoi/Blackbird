using System;
namespace Blackbird.Domain.Entities
{
    public class Person : Entity<Guid>
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public DateTime Birthdate { get; set; }

        public Person(string name, string email, DateTime birthdate) 
            : base(Guid.NewGuid())
        {
            Name = name;
            Email = email;
            Birthdate = birthdate;
        }
    }
}
