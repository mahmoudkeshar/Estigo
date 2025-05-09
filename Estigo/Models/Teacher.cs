﻿using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Estigo.Models
{
    public class Teacher:ApplicationUser
    {
        public string Subject { get; set; }
        public string? Notes { get; set; }

        public string? image { get; set; }

        // Foreign Key 
        public int? courseId { get; set; }

        // Navigation property 
        public virtual ICollection<Course> CoursesTaught { get; set; }

    }
}
