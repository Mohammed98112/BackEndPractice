using System;
using System.Collections.Generic;
using System.Text;

namespace UniversitySystem.Models
{
    public class Instructor
    {
        public int instructorId { get; set; }        // system generated
        public string fullName { get; set; }          // user input
        public string email { get; set; }               // user input
        public string officeNumber { get; set; }         // user input 
        public DateTime hireDate { get; set; }            // user input
        public decimal salary { get; set; }                 // user input
        public string academicTitle { get; set; }            // user input (from list)
    }
}
