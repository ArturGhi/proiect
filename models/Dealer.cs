using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace proiect.models
{
    public class Dealer
    {
        public int ID { get; set; }
        [Required, StringLength(50, MinimumLength = 2)]
        public string DealerName { get; set; }
        public ICollection<masina> masini { get; set; }
    }
}
