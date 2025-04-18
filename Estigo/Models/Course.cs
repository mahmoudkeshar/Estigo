﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Estigo.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        [Required]
        public string CourseTitle { get; set; }
        public string? Description { get; set; }
        public string? Logo { get; set; }
        public int Price { get; set; }
        public bool Available { get; set; } = true;

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreatedAt { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? UpdatedAt { get; set; }

        // Foreign key
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        [ForeignKey("Teacher")] 
        public string? TeacherId { get; set; }
        public Teacher? Teacher { get; set; }

        // Navigation property
        public virtual ICollection<Student> students { get; set; }
        public ICollection<lesson> lessons { get; set; }

        public virtual ICollection<Payment> Payments { get; set; }


        



    }
}
