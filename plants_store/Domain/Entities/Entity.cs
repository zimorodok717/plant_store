using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace online_pharmacy.Domain.Entities
{
    public abstract class Entity
    {
        [Required] public Guid Id { get; set; }
    }
}
