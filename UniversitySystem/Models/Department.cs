using System;
using System.Collections.Generic;
using System.Text;

namespace UniversitySystem.Models
{
    public class Department
    {
        public int departmentId { get; set; }         // system generated
        public string departmentName { get; set; }      // user input
        public string building { get; set; }              // user input 
        public decimal budget { get; set; }                 // user input
        public int? headInstructorId { get; set; }            // foreign key 
    }
}
