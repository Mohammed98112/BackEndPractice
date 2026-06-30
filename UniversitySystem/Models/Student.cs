using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UniversitySystem.Models
{
    public class Student
    {
        [key]
        [Required]
        public int studentId { get; set; }          // system generated
        [Required]
        [MaxLength(100)]
        public string fullName { get; set; }         // user input
        [Required]
        [MaxLength(150)]
        public string email { get; set; }             // user input
        [MaxLength(20)]
        public string phoneNumber { get; set; }       // user input 
        [Required]
        public DateTime dateOfBirth { get; set; }      // user input
        [Required]
        [Range(2000,2030)]
        public int enrollmentYear { get; set; }         // user input
        [Range(0.0, 4.0)]
        public decimal gpa { get; set; }                 // System calculated
    }
}
