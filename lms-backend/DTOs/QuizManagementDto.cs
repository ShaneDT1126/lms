﻿using lms_backend.Models;

namespace lms_backend.DTOs
{
    public class QuizManagementDto
    {
        public int QuizId { get; set; }
        public int StudentId { get; set; }
        public Quiz Quiz { get; set; }
        public Student Student { get; set; }
        public int Score { get; set; }
    }
}
