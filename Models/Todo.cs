using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TodoManagerApi.Models
{
    public class Todo
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage ="Tittle should be less than 50 characters.")]
        public string Tittle { get; set; }

        [Required]
        [MaxLength(500, ErrorMessage = "Description should be less than 500 characters.")]
        public string Description { get; set; }
    }
}
