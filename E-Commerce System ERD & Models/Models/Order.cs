using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace E_Commerce_System_ERD___Models.Models
{
    public class Order
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int orderId { get; set; }                 // system generated

        [ForeignKey("User")]
        public int userId { get; set; }                  // foreign key

        [Required]
        public DateTime orderDate { get; set; }          // system generated

        [Required]
        [Range(0, double.MaxValue)]
        public decimal totalAmount { get; set; }         // System calculated

        [Required]
        [StringLength(30)]
        public string status { get; set; } = "Pending";  // default value

        [Required]
        [StringLength(300)]
        public string shippingAddress { get; set; }      // user input

        [Required]
        [StringLength(50)]
        public string paymentMethod { get; set; }        // user input 
    }
}
