﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataInteraction.Data.Entities
{
    public class Instructor
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FirstNmae { get; set; }
        [Required]
        public string LastName { get; set; }

        [Required]
        public string Email { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public DateTime DateofHire { get; set; }
    }
}
