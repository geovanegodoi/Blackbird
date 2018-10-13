using System;
namespace Blackbird.Application.TO
{
    public class PersonTO : EntityTO<Guid>
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public DateTime Birthdate { get; set; }
    }
}
