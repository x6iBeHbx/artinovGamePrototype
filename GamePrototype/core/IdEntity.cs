using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePrototypeClasses.core
{
    public class IdEntity
    {
        [Required]
        public Guid Id { get; protected set; }

        public IdEntity()
        {
            Id = new Guid();
        }
    }
}
