using System;
namespace Blackbird.Application.TO
{
    public class ProductTO : EntityTO<Guid>
    {
        public string Name { get; set; }

        public string Description { get; set; }
    }
}
