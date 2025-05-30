﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Estigo.Models
{
    public class BankOfQuestion
    {
        public int Id { get; set; }
        public string QuestionText { get; set; }
        public string? OptionA { get; set; }
        public string? OptionB { get; set; }
        public string? OptionC { get; set; }
        public string? OptionD { get; set; }
        public string CorrectAnswer { get; set; }

        // Navigation Properties
        [ForeignKey("Exam")]
        public int ExamId { get; set; }
        public Exam Exam { get; set; }


    }
}
