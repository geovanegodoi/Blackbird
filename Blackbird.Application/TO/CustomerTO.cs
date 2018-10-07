using System;
namespace Blackbird.Application.TO
{
    public class CustomerTO : PersonTO
    {
        public string Login { get; set; }

        public string Password { get; set; }
    }
}
