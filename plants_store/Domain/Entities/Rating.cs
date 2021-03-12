using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace online_pharmacy.Domain.Entities
{
    public class Rating : Entity
    {
        [Required] public Guid IdOfMed { get; set; }

        [Required] public int NumberOfCalls { get; set; }
    }
}
