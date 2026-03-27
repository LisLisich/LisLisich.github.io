using System;
using System.Collections.Generic;

namespace task6.Models
{
    /// <summary>
    /// Класс вопроса теста
    /// </summary>
    public class Question
    {
        public string Id { get; set; }
        public string Text { get; set; }
        public string Type { get; set; } // "riddle", "proverb", "custom"
        public List<string> Answers { get; set; }
        public int CorrectIndex { get; set; }
        public string ImagePath { get; set; }
        public string Hint { get; set; }
        public int Difficulty { get; set; }
        public string Topic { get; set; }

        public Question()
        {
            Answers = new List<string>();
            ImagePath = string.Empty;
        }
    }
}