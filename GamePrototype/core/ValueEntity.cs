using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePrototypeClasses.core
{
    public class ValueEntity : IdEntity
    {
        [Required]
        public int Value { get; set; }
    }
}
