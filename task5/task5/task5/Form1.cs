using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DictionaryLibrary;

namespace task5
{
    public partial class Form1 : Form
    {
        private Slovar slovar;
        private string currentDictionaryPath;

        public Form1()
        {
            InitializeComponent();
            UpdateStatus("Готов");
        }

        private void BtnSelectDict_Click(object sender, EventArgs e)
        {
            openFileDialog.Title = "Выберите файл словаря";
            openFileDialog.Filter = "Текстовые файлы|*.txt|Все файлы|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    slovar = new Slovar(openFileDialog.FileName);
                    currentDictionaryPath = openFileDialog.FileName;
                    lblDictPath.Text = openFileDialog.FileName;
                    UpdateWordList();
                    UpdateStatus($"Словарь загружен: {slovar.Count} слов");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            UpdateWordList();
        }

        private void BtnSort_Click(object sender, EventArgs e)
        {
            if (slovar != null)
            {
                slovar.SortAlphabetically();
                UpdateWordList();
                UpdateStatus("Словарь отсортирован");
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (slovar == null)
            {
                MessageBox.Show("Сначала выберите словарь!", "Предупреждение",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string word = tbWord.Text.Trim();
            if (string.IsNullOrEmpty(word))
            {
                MessageBox.Show("Введите слово!", "Предупреждение",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (slovar.AddWord(word))
            {
                UpdateWordList();
                UpdateStatus($"Слово '{word}' добавлено");
                tbWord.Clear();
            }
            else
            {
                MessageBox.Show("Такое слово уже есть в словаре!", "Информация",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            if (slovar == null)
            {
                MessageBox.Show("Сначала выберите словарь!", "Предупреждение",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string word = tbWord.Text.Trim();
            if (string.IsNullOrEmpty(word))
            {
                MessageBox.Show("Введите слово!", "Предупреждение",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (slovar.RemoveWord(word))
            {
                UpdateWordList();
                UpdateStatus($"Слово '{word}' удалено");
                tbWord.Clear();
            }
            else
            {
                MessageBox.Show("Слово не найдено в словаре!", "Информация",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (slovar == null)
            {
                MessageBox.Show("Сначала выберите словарь!", "Предупреждение",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                "Сохранить изменения в новый файл? Основной словарь не будет изменён.",
                "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                saveFileDialog.Title = "Сохранить словарь как";
                saveFileDialog.Filter = "Текстовые файлы|*.txt";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    slovar.SaveToFile(saveFileDialog.FileName);
                    UpdateStatus($"Словарь сохранён в {saveFileDialog.FileName}");
                }
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (slovar == null)
            {
                MessageBox.Show("Сначала выберите словарь!", "Предупреждение",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ✅ Используем поля напрямую (не через Controls.Find!)
            int count = (int)nudCount.Value;
            bool isConsonant = rbConsonants.Checked;

            var results = slovar.SearchByVariant6(count, isConsonant);

            lbResults.Items.Clear();
            foreach (var word in results)
            {
                lbResults.Items.Add(word);
            }

            lblResultCount.Text = $"Найдено: {results.Count}";
            UpdateStatus($"Найдено {results.Count} слов");
        }

        private void BtnSaveResults_Click(object sender, EventArgs e)
        {
            if (lbResults.Items.Count == 0)
            {
                MessageBox.Show("Нет результатов для сохранения!", "Предупреждение",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            saveFileDialog.Title = "Сохранить результаты поиска";
            saveFileDialog.Filter = "Текстовые файлы|*.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                List<string> results = new List<string>();
                foreach (var item in lbResults.Items)
                {
                    results.Add(item.ToString());
                }

                if (slovar.SaveSearchResults(results, saveFileDialog.FileName))
                {
                    UpdateStatus($"Результаты сохранены в {saveFileDialog.FileName}");
                }
                else
                {
                    MessageBox.Show("Ошибка сохранения!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnFuzzySearch_Click(object sender, EventArgs e)
        {
            if (slovar == null)
            {
                MessageBox.Show("Сначала выберите словарь!", "Предупреждение",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string pattern = tbFuzzy.Text.Trim();
            if (string.IsNullOrEmpty(pattern))
            {
                MessageBox.Show("Введите слово для поиска!", "Предупреждение",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var results = slovar.FuzzySearch(pattern, 3);

            lbResults.Items.Clear();
            foreach (var word in results)
            {
                lbResults.Items.Add(word);
            }

            lblResultCount.Text = $"Найдено: {results.Count}";
            UpdateStatus($"Нечёткий поиск: {results.Count} слов");
        }

        private void UpdateWordList()
        {
            if (slovar == null) return;

            lbWords.Items.Clear();
            foreach (var word in slovar.Words)
            {
                lbWords.Items.Add(word);
            }
        }

        private void UpdateStatus(string message)
        {
            statusLabel.Text = message;
        }
    }
}