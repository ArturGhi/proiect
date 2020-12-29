using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace proiect.models
{
    public class masina
    {
        public int id { get; set; }
        [Required, StringLength(150, MinimumLength = 2)]
        [Display(Name = "Marca")]
        public string marca { get; set; }
        [Required, StringLength(50, MinimumLength = 2)]
        [Display(Name = "Model")]
        public string model { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "Numar negativ.")]
        [Column(TypeName = "decimal(10, 2)")]
        [Display(Name = "Pret")]
        public decimal pret { get; set; }
        [Display(Name = "Data publicarii")]
        [DataType(DataType.Date)]
        public DateTime PublishingDate { get; set; }

        [Display(Name = "Dealer")]
        public int DealerID { get; set; }
        public Dealer Dealer { get; set; }
    }
}
