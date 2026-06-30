using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace UniversitySystem.Models
{
    public class Department
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int departmentId { get; set; }         // system generated
        [Required]
        [StringLength(100)]
        public string? departmentName { get; set; }      // user input
        [StringLength(50)]
        public string building { get; set; }              // user input
        [Required]
        [Range(0,double.MaxValue)]
        public decimal budget { get; set; }                 // user input
        [ForeignKey("Instuctor")]
        public int? headInstructorId { get; set; }            // foreign key 
    }
}
