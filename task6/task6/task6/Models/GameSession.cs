using System;
using System.Collections.Generic;
using System.Linq;

namespace task6.Models
{
    /// <summary>
    /// Класс управления игровой сессией
    /// </summary>
    public class GameSession
    {
        public string CurrentTopic { get; set; }
        public int CurrentLevel { get; set; }
        public List<Question> SessionQuestions { get; set; }
        public int CurrentQuestionIndex { get; set; }
        public double Score { get; set; }
        public DateTime StartTime { get; set; }
        public TimeSpan TimeLimit { get; set; }
        public bool IsFinished { get; set; }

        private Random random = new Random();

        public GameSession()
        {
            SessionQuestions = new List<Question>();
            TimeLimit = TimeSpan.FromMinutes(10);
            CurrentLevel = 1;
            Score = 0;
        }

        /// <summary>
        /// Генерирует сессию из случайных вопросов
        /// </summary>
        public void GenerateSession(List<Question> allQuestions, int count = 5)
        {
            var filtered = allQuestions.Where(q => q.Difficulty == CurrentLevel).ToList();
            SessionQuestions = filtered.OrderBy(x => random.Next()).Take(count).ToList();
            CurrentQuestionIndex = 0;
            Score = 0;
            StartTime = DateTime.Now;
            IsFinished = false;
        }

        public Question GetCurrentQuestion()
        {
            if (CurrentQuestionIndex < SessionQuestions.Count)
                return SessionQuestions[CurrentQuestionIndex];
            return null;
        }

        public bool NextQuestion()
        {
            CurrentQuestionIndex++;
            if (CurrentQuestionIndex >= SessionQuestions.Count)
            {
                IsFinished = true;
                return false;
            }
            return true;
        }

        public void AddScore(double points)
        {
            Score += points;
        }

        public TimeSpan GetRemainingTime()
        {
            var elapsed = DateTime.Now - StartTime;
            return TimeLimit - elapsed;
        }

        public bool CanAdvanceToNextLevel()
        {
            return Score >= 80;
        }
    }
}