using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GamePrototypeClasses.core
{
    [DataContract]
    public class IdEntity
    {
        [Key]
        [Required]
        public Guid Id { get; set; }

        public IdEntity()
        {
            Id = Guid.NewGuid();
        }
    }
}
