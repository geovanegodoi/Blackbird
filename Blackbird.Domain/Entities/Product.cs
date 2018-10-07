using System;
namespace Blackbird.Domain.Entities
{
    public class Product : Entity<Guid>
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public Product(string name, string description)
            : base(Guid.NewGuid())
        {
            Name = name;
            Description = description;
        }
    }
}
