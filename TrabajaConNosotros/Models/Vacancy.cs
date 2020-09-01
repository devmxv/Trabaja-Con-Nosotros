using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrabajaConNosotros.Models
{
    public class Vacancy
    {
        [Key]
        public int Id { get;set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public int Category { get; set; }
        [Required]
        public float Salary { get; set; }
        [Required]
        public int Status { get; set; }
        public string Comments { get; set; }
    }
}
