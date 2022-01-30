using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    class Car
    {
        [Key]
        public int Id { get; set; } 

        [Required]
        public string Make { get; set; }
        
        [Required]
        public string Model { get; set; }

        [Required]
        public double Range { get; set; }
    }
}
