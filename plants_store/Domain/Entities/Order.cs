using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace online_pharmacy.Domain.Entities
{
    public class Order : Entity
    {


        [Display(Name = "Форма оплаты")]
        public string Pay { get; set; }

        [Display(Name = "Форма доставки")]
        public string Delivery { get; set; }

        [Display(Name = "Контакты покупателя")]
        public string Email { get; set; }

        public int MedicineId { get; set; }

        [ForeignKey("MedicineId")] public Medicine Medicines { get; set; }
    }
}
