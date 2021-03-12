using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace online_pharmacy.Domain.Entities
{
    public class Medicine:Entity
    {

        [Display(Name = "Название категории")]
        public string Title { get; set; }

        [Display(Name = "Описание категории")]
        public string Description { get; set; }

        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")] public Category Category { get; set; }

        
    }
}
