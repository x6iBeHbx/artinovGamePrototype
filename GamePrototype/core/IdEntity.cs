using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePrototypeClasses.core
{
    public class IdEntity
    {
        public Guid Id { get; protected set; }

        public IdEntity()
        {
            Id = new Guid();
        }
    }
}
