using Cms.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Domain.Roles
{
    public class AccesRight : ValueObject
    {

    }
    public class Editright : AccesRight
    { }
    public class ReadRight : AccesRight
    { }
    public class DeleteRight : AccesRight
    { }

    public class UpdateRight : AccesRight
    { }
}
