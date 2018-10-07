using System;
namespace Blackbird.Domain.Entities
{
    public class Customer : Person
    {
        public string Login { get; set; }

        public string Password { get; set; }

        public Customer(string name, string email, DateTime birthdate, string login, string password)
            : base(name, email, birthdate)
        {
            Login = login;
            Password = password;
        }
    }
}
