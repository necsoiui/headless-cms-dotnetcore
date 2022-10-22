using Cms.Domain.Contracts;
using Cms.Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Domain.Account
{
    internal class Account : Entity
    {
        public User User;
        public List<Role> Roles;

        public Account(Guid id):base(id)
        {

        }
    }
}
