using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataInteraction.Data.Entities
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FirstNmae { get; set; }
        [Required]
        public string LastName { get; set; }
        
        [Required]
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
    }
}
