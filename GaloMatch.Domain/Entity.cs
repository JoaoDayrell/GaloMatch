using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaloMatch.Domain
{
    public class Entity
    {
        public Guid Id { get; init; }

        public Entity()
        {
            Id = Guid.NewGuid();
        }   
    }
}
