using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace UniversitySystem.Models
{
    public class Enrollment
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int enrollmentId { get; set; }          // system generated
        [ForeignKey("Student")]
        public int studentId { get; set; }                // foreign key
        [ForeignKey("Customer")]
        public int courseId { get; set; }                   // foreign key
        [Required]
        public DateTime enrollmentDate { get; set; }           // system generated
        [StringLength(2)]
        public string? finalGrade { get; set; }                   // user input 
        [Required]
        [StringLength(20)]
        public string status { get; set; } = "Progress";                      // default value "In Progress" | "Completed" | "Withdrawn"
    }
}
