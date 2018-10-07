using System;
namespace Blackbird.Application.TO
{
    public class PersonTO : ITO
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public DateTime Birthdate { get; set; }
    }
}
