using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace GamePrototypeClasses.core
{
    [Serializable, DataContract]
    public class IdEntity
    {
        [Key]
        [Required]
        [DataMember]
        public Guid Id { get; set; }
        public IdEntity()
        {
            Id = Guid.NewGuid();
        }
    }
}
