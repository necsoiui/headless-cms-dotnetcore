using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Domain.Contracts
{
    public abstract class Entity
    {
        public Guid Id { get; set; }

        public Entity():this(Guid.NewGuid())
        {

        }
        protected Entity(Guid guid)
        {
            Id = guid;
        }
    }
}
