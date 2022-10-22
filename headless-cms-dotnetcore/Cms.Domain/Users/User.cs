using Cms.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Domain.Users
{
    internal class User : Entity
    {
        public Name Name { get; set; }
        public Password Password { get; set; }

        public Email Email { get; set; }
        public UserName UserName { get; set; }

        public User(string firstName, string lastname, string password, string email, string userName)
            : this(Guid.NewGuid(), firstName, lastname, password, email, userName) { }

        public User(Guid id, string firstName, string lastname, string password, string email, string userName) : base(id)
        {
            Name = new Name(firstName, lastname);
            Password = new Password(password);
            Email = new Email(email);
            UserName = new UserName(userName);
        }
    }
}
