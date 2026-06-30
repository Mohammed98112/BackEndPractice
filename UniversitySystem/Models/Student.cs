using System;
using System.Collections.Generic;
using System.Text;

namespace UniversitySystem.Models
{
    public class Student
    {
        public int studentId { get; set; }          // system generated
        public string fullName { get; set; }         // user input
        public string email { get; set; }             // user input
        public string phoneNumber { get; set; }       // user input 
        public DateTime dateOfBirth { get; set; }      // user input
        public int enrollmentYear { get; set; }         // user input
        public decimal gpa { get; set; }                 // System calculated
    }
}
