using System;
namespace Blackbird.Application.TO
{
    public class EntityTO<TKey> : ITO
    {
        public TKey Id { get; set; }
    }
}
