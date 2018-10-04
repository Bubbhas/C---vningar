using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Models
{

    
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [Range(1, 1000)]
        [RegularExpression(@"^[\d]+$", ErrorMessage = "Måste vara siffror")]
        public decimal Price { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }


    }
}
