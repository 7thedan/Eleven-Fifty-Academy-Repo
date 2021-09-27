using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataInteraction.Data.Entities
{
    public class Cohort
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string CourseCode { get; set; }
        
        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        [Required]
        public string Langugage { get; set; }

        [Required]
        public bool FullTime { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
        public virtual ICollection<InstructorAssignments> InstructorAssignments { get; set; } = new List<InstructorAssignments>();
    }
}
