using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace E_Commerce_System_EFCore.Models
{
    public class Category
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int categoryId { get; set; }              // system generated

        [Required]
        [StringLength(100)]
        public string categoryName { get; set; }         // user input

        [StringLength(500)]
        public string? description { get; set; }          // user input 

        [StringLength(300)]
        public string? imageUrl { get; set; }             // user input 
    }
}
