using Cms.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Domain.Users
{
    public class Password : ValueObject
    {
        public readonly string password;

        public Password(string password)
        {
            this.password = password;
        }

        private string Hash()
        {
            throw new NotImplementedException();
        }
    }
}
