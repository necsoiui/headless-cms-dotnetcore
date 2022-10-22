using Cms.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Domain.Users
{
    public class Email : ValueObject
    {
        public readonly string email;

        public Email(string email)
        {
            this.email = email;
        }

        public bool Valid()
        {
            // todo: implement validation
            throw new NotImplementedException();
        }
    }
}
