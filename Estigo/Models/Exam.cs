﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Estigo.Models
{
    public class Exam
    {
        [Key]
        public int Id { get; set; }
        public string ExamTitle { get; set; }
        public string ExamDescription { get; set; }
        public string Grade { get; set; }
        public int attempts { get; set; }
        public bool final { get; set; } = false;

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreatedAt { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? UpdatedAt { get; set; }

        [ForeignKey("Lesson")]
        public int lessonId { get; set; }
        public lesson Lesson { get; set; }

        public ICollection<BankOfQuestion> Questions { get; set; }

    }
}
