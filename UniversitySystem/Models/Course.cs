using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace UniversitySystem.Models
{
    public class Course
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int courseId { get; set; }              // system generated
        [Required]
        [StringLength(50)]
        public string courseCode { get; set; }           // user input
        [Required]
        [StringLength(50)]
        public string courseTitle { get; set; }            // user input
        [Required]
        [Range(1, 6)]
        public int creditHours { get; set; }                 // user input
        [ForeignKey("Depatment")]
        public int departmentId { get; set; }                  // foreign key
        [ForeignKey("Instructor")]
        public int instructorId { get; set; }                   // foreign key 
        [Required]
        [StringLength(20)]
        public string semesterOffered { get; set; }                // user input (from list)
    }
}
