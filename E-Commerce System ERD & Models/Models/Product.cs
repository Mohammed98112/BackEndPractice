using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace E_Commerce_System_ERD___Models.Models
{
    public class Product
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int productId { get; set; }               // system generated

        [Required]
        [StringLength(150)]
        public string productName { get; set; }          // user input

        [StringLength(1000)]
        public string? description { get; set; }          // user input 

        [Required]
        [Range(0.01, double.MaxValue)]
        public decimal price { get; set; }               // user input

        [Required]
        [Range(0, int.MaxValue)]
        public int stockQuantity { get; set; } = 0;      // default value

        [StringLength(300)]
        public string? imageUrl { get; set; }             // user input 

        [ForeignKey("Category")]
        public int categoryId { get; set; }              // foreign key

        [Required]
        public DateTime createdAt { get; set; }          // system generated

        public bool isAvailable { get; set; } = true;    // default value
    }
}
