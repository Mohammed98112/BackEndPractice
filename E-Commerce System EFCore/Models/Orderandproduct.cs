using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace E_Commerce_System_EFCore.Models
{
    // class for the M:N relationship between Order and Product
    public class OrderProduct
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int orderProductId { get; set; }          // system generated

        [ForeignKey("Order")]
        public int orderId { get; set; }                 // foreign key

        [ForeignKey("Product")]
        public int productId { get; set; }               // foreign key

        [Required]
        [Range(1, 999)]
        public int quantity { get; set; }                // user input
    }
}
