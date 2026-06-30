using System;
using System.Collections.Generic;
using System.Text;

namespace UniversitySystem.Models
{
    public class Course
    {
        public int courseId { get; set; }              // system generated
        public string courseCode { get; set; }           // user input
        public string courseTitle { get; set; }            // user input
        public int creditHours { get; set; }                 // user input
        public int departmentId { get; set; }                  // foreign key
        public int instructorId { get; set; }                   // foreign key 
        public string semesterOffered { get; set; }                // user input (from list)
    }
}
