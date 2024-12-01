﻿namespace exam.Models
{
    public class Question
    {
        public int QuestionID {  get; set; }
        public string? QuestionText {  get; set; }
        public string? Answer1 {  get; set; }
        public string? Answer2 { get; set; }
        public string? Answer3 { get; set; }
        public string? Answer4 { get; set; }
        public int CorrectAnswer {  get; set; }
        public int EventID {  get; set; }
    }
}
