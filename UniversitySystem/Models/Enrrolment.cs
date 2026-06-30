using System;
using System.Collections.Generic;
using System.Text;

namespace UniversitySystem.Models
{
    public class Enrollment
    {
        public int enrollmentId { get; set; }          // system generated
        public int studentId { get; set; }                // foreign key
        public int courseId { get; set; }                   // foreign key
        public DateTime enrollmentDate { get; set; }           // system generated
        public string finalGrade { get; set; }                   // user input 
        public string status { get; set; }                         // default value "In Progress" | "Completed" | "Withdrawn"
    }
}
