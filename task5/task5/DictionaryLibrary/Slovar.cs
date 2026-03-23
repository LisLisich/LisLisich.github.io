using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace DictionaryLibrary
{
    public class Slovar
    {
        private List<string> list = new List<string>();
        private string filename;
        private int count;

        public Slovar(string filename)
        {
            this.filename = filename;
            OpenFile();
            count = list.Count;
        }

        public int Count => count;

        public List<string> Words => new List<string>(list);

        private void OpenFile()
        {
            try
            {
                list.Clear();
                if (!File.Exists(filename))
                    throw new FileNotFoundException("Файл словаря не найден!");

                string[] lines = File.ReadAllLines(filename, Encoding.UTF8);
                foreach (string line in lines)
                {
                    string word = line.Trim().ToLower();
                    if (!string.IsNullOrEmpty(word) && !list.Contains(word))
                        list.Add(word);
                }
                count = list.Count;
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка доступа к файлу: {ex.Message}");
            }
        }

        public void SaveToFile(string newFilename)
        {
            try
            {
                File.WriteAllLines(newFilename, list, Encoding.UTF8);
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка сохранения файла: {ex.Message}");
            }
        }

        public bool AddWord(string word)
        {
            string normalizedWord = word.Trim().ToLower();
            if (string.IsNullOrEmpty(normalizedWord))
                return false;

            if (list.Contains(normalizedWord))
                return false;

            list.Add(normalizedWord);
            count = list.Count;
            return true;
        }

        public bool RemoveWord(string word)
        {
            string normalizedWord = word.Trim().ToLower();
            if (list.Remove(normalizedWord))
            {
                count = list.Count;
                return true;
            }
            return false;
        }

        public List<string> SearchByPrefix(string prefix)
        {
            return list.Where(w => w.StartsWith(prefix.ToLower())).ToList();
        }

        public List<string> SearchByVariant6(int consonantCount, bool isConsonant = true)
        {
            // Вариант 6: поиск по количеству согласных или гласных
            return list.Where(w =>
            {
                int count = isConsonant ? CountConsonants(w) : CountVowels(w);
                return count == consonantCount;
            }).ToList();
        }

        public static int CountConsonants(string word)
        {
            string consonants = "бвгджзйклмнпрстфхцчшщbcdfghjklmnpqrstvwxyz";
            return word.ToLower().Count(c => consonants.Contains(c));
        }

        public static int CountVowels(string word)
        {
            string vowels = "аеёиоуыэюяaeiouy";
            return word.ToLower().Count(c => vowels.Contains(c));
        }

        public List<string> FuzzySearch(string pattern, int maxDistance = 3)
        {
            return list.Where(w =>
                LevenshteinDistance.Calculate(w, pattern.ToLower()) <= maxDistance
            ).ToList();
        }

        public bool SaveSearchResults(List<string> results, string outputFilename)
        {
            try
            {
                File.WriteAllLines(outputFilename, results, Encoding.UTF8);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void SortAlphabetically()
        {
            list.Sort();
        }
    }
}