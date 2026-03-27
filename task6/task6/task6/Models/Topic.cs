using System.Collections.Generic;

namespace task6.Models
{
    /// <summary>
    /// Класс темы с уровнями сложности
    /// </summary>
    public class Topic
    {
        public string Name { get; set; }
        public Dictionary<int, List<Question>> Levels { get; set; }

        public Topic()
        {
            Levels = new Dictionary<int, List<Question>>
            {
                { 1, new List<Question>() },
                { 2, new List<Question>() },
                { 3, new List<Question>() }
            };
        }

        public List<Question> GetQuestionsByLevel(int level)
        {
            return Levels.ContainsKey(level) ? Levels[level] : new List<Question>();
        }
    }
}