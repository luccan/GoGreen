using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GoGreen.Models
{
    public class Vegetable
    {
        public int Id { get; set; }

        [StringLength(200, MinimumLength = 1)]
        [Required]
        public string Name { get; set; }

        [Column(TypeName = "decimal(19,2)")]
        [DisplayFormat(DataFormatString = "{0:#,##0.00}", ApplyFormatInEditMode = true)]
        [Range(0.0, Double.MaxValue, ErrorMessage = "The field {0} must be greater than or equal to {1}.")]
        [Required]
        public decimal Price { get; set; }
    }
}
