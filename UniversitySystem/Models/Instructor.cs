using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace UniversitySystem.Models
{
    public class Instructor
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int instructorId { get; set; }        // system generated
        [Required]
        [StringLength(100)]
        public string fullName { get; set; }          // user input
        [Required]
        [StringLength(150)]
        public string email { get; set; }               // user input
        [StringLength(150)]
        public string? officeNumber { get; set; }         // user input 
        [Required]
        public DateTime hireDate { get; set; }            // user input
        [Required]
        [Range(0, double.MaxValue)]
        public decimal salary { get; set; }                 // user input
        [Required]
        [StringLength(50)]
        public string academicTitle { get; set; }            // user input (from list)
    }
}
