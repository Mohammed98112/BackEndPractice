    using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace E_Commerce_System_EFCore.Models
{
    public class User
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int userId { get; set; }                  // system generated

        [Required]
        [StringLength(50)]
        public string username { get; set; }             // user input

        [Required]
        [StringLength(150)]
        public string email { get; set; }                // user input

        [Required]
        [StringLength(256)]
        public string passwordHash { get; set; }         // system generated

        [Required]
        [StringLength(100)]
        public string fullName { get; set; }             // user input

        [StringLength(20)]
        public string? phoneNumber { get; set; }          // user input

        [StringLength(300)]
        public string? address { get; set; }              // user input 

        [Required]
        public DateTime registrationDate { get; set; }   // system generated

        public bool isActive { get; set; } = true;       // default value
    }
}
