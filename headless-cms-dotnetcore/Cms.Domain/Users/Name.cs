using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Domain.Users
{
    internal class Name
    {
        private readonly string firstName;
        private readonly string lastName;

        public Name(string firstName, string lastName)
        {
            ValidateName(firstName, lastName)

            this.firstName = firstName;
            this.lastName = lastName;
        }

        public override string ToString()
        {
            return $"{firstName} , {lastName}";
        }

        private void ValidateName(string firstName, string lastName)
        {
            if (firstName == null && lastName == null) { }

            else throw new Exception();
        }
    }
}
