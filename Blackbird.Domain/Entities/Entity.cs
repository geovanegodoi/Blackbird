using System;
namespace Blackbird.Domain.Entities
{
    public abstract class Entity<TKey> : IEntity<TKey>
    {
        public TKey Id { get; set; }

        protected Entity(TKey id)
        {
            Id = id;
        }
    }
}
