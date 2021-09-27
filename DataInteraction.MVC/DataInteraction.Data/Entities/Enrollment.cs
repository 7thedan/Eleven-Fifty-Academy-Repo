using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataInteraction.Data.Entities
{
    public class Enrollment
    {
        [Key]
        public int Id { get; set; }
        
        [ForeignKey(nameof(Student))]
        public int StudentId { get; set; }
        public virtual Student Student { get; set; }

        [ForeignKey(nameof(Cohort))]
        public int CohortId { get; set; }
        public virtual Cohort Cohort { get; set; }
    }
}
