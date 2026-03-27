using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using task6.Models;

namespace task6.Services
{
    /// <summary>
    /// Класс для работы с XML-файлом (чтение/запись вопросов)
    /// </summary>
    public class XmlManager
    {
        private string filePath;

        public XmlManager(string path)
        {
            filePath = path;
        }

        /// <summary>
        /// Загружает все темы из XML-файла
        /// </summary>
        public List<Topic> LoadAllTopics()
        {
            var topics = new List<Topic>();

            if (!File.Exists(filePath)) return topics;

            var doc = new XmlDocument();
            doc.Load(filePath);

            var topicNodes = doc.SelectNodes("//topic");
            foreach (XmlNode topicNode in topicNodes)
            {
                var topic = new Topic
                {
                    Name = topicNode.Attributes["name"]?.Value ?? "Без названия"
                };

                var levelNodes = topicNode.SelectNodes("level");
                foreach (XmlNode levelNode in levelNodes)
                {
                    if (!int.TryParse(levelNode.Attributes["number"]?.Value, out int level))
                        level = 1;

                    var questionNodes = levelNode.SelectNodes("question");
                    foreach (XmlNode qNode in questionNodes)
                    {
                        var question = new Question
                        {
                            Id = qNode.Attributes["id"]?.Value ?? Guid.NewGuid().ToString(),
                            Text = qNode.SelectSingleNode("text")?.InnerText ?? "",
                            Type = qNode.Attributes["type"]?.Value ?? "custom",
                            Hint = qNode.SelectSingleNode("hint")?.InnerText ?? "",
                            ImagePath = qNode.SelectSingleNode("image")?.InnerText ?? "",
                            Difficulty = level,
                            Topic = topic.Name
                        };

                        var answersNode = qNode.SelectSingleNode("answers");
                        if (answersNode != null)
                        {
                            int idx = 0;
                            foreach (XmlNode ansNode in answersNode.SelectNodes("answer"))
                            {
                                question.Answers.Add(ansNode.InnerText);
                                if (ansNode.Attributes["correct"]?.Value == "true")
                                    question.CorrectIndex = idx;
                                idx++;
                            }
                        }

                        if (topic.Levels.ContainsKey(level))
                            topic.Levels[level].Add(question);
                    }
                }
                topics.Add(topic);
            }
            return topics;
        }

        /// <summary>
        /// Сохраняет тему в XML-файл
        /// </summary>
        public void SaveTopic(Topic topic)
        {
            XmlDocument doc = new XmlDocument();

            if (File.Exists(filePath))
            {
                doc.Load(filePath);
            }
            else
            {
                var decl = doc.CreateXmlDeclaration("1.0", "utf-8", null);
                doc.AppendChild(decl);
                var newRoot = doc.CreateElement("quiz");
                doc.AppendChild(newRoot);
            }

            var xmlRoot = doc.DocumentElement;
            if (xmlRoot == null) return;

            var existing = xmlRoot.SelectSingleNode($"//topic[@name='{topic.Name}']");
            if (existing != null)
                xmlRoot.RemoveChild(existing);

            var topicNode = doc.CreateElement("topic");
            topicNode.SetAttribute("name", topic.Name);

            foreach (var levelPair in topic.Levels)
            {
                var levelNode = doc.CreateElement("level");
                levelNode.SetAttribute("number", levelPair.Key.ToString());

                foreach (var q in levelPair.Value)
                {
                    var qNode = doc.CreateElement("question");
                    qNode.SetAttribute("id", q.Id);
                    qNode.SetAttribute("type", q.Type);

                    var textNode = doc.CreateElement("text");
                    textNode.InnerText = q.Text;
                    qNode.AppendChild(textNode);

                    if (!string.IsNullOrEmpty(q.Hint))
                    {
                        var hintNode = doc.CreateElement("hint");
                        hintNode.InnerText = q.Hint;
                        qNode.AppendChild(hintNode);
                    }

                    if (!string.IsNullOrEmpty(q.ImagePath))
                    {
                        var imgNode = doc.CreateElement("image");
                        imgNode.InnerText = q.ImagePath;
                        qNode.AppendChild(imgNode);
                    }

                    var answersNode = doc.CreateElement("answers");
                    for (int i = 0; i < q.Answers.Count; i++)
                    {
                        var ansNode = doc.CreateElement("answer");
                        if (i == q.CorrectIndex)
                            ansNode.SetAttribute("correct", "true");
                        ansNode.InnerText = q.Answers[i];
                        answersNode.AppendChild(ansNode);
                    }
                    qNode.AppendChild(answersNode);
                    levelNode.AppendChild(qNode);
                }
                topicNode.AppendChild(levelNode);
            }
            xmlRoot.AppendChild(topicNode);
            doc.Save(filePath);
        }
    }
}