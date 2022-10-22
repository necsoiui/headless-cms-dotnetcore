using Cms.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Domain.Roles
{
    internal class Role : Entity
    {
        public RoleName Rolename;
        public List<AccesRight> AccesRight;

        public Role(Guid id, string RoleName):base(id)
        {
            Validate(); 
        }
        public Role(string RoleName) 
        {
            Validate();
        }
        private void Validate()
        {
            throw new TypeLoadException();
        }
    }
}
