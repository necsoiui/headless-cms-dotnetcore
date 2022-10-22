using Cms.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Domain.Roles
{
    internal class RoleName : ValueObject
    {
        private readonly string roleName;
        public RoleName(string roleName)
        {
            this.roleName = roleName;
        }

    }
}
