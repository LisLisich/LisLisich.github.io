using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using task6.Forms;
using task6.Models;
using task6.Services;

namespace task6
{
    public partial class AdminForm : Form
    {
        private XmlManager xmlManager;
        private Topic currentTopic;

        public AdminForm(XmlManager manager)
        {
            InitializeComponent();
            xmlManager = manager;
            LoadTopics();
        }

        private void LoadTopics()
        {
            cmbTopics.Items.Clear();
            var topics = xmlManager.LoadAllTopics();
            foreach (var t in topics)
                cmbTopics.Items.Add(t.Name);

            if (cmbTopics.Items.Count > 0)
                cmbTopics.SelectedIndex = 0;
        }

        private void cmbTopics_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTopics.SelectedItem == null) return;

            var topics = xmlManager.LoadAllTopics();
            currentTopic = topics.Find(t => t.Name == cmbTopics.SelectedItem.ToString());
            LoadQuestions(null, null);
        }

        private void LoadQuestions(object sender, EventArgs e)
        {
            if (currentTopic == null) return;

            int level = (int)numLevel.Value;
            lstQuestions.Items.Clear();

            foreach (var q in currentTopic.GetQuestionsByLevel(level))
            {
                string preview = q.Text.Length > 40 ? q.Text.Substring(0, 40) + "..." : q.Text;
                lstQuestions.Items.Add($"{q.Type}: {preview}");
            }
        }

        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            if (currentTopic == null)
            {
                MessageBox.Show("Сначала выберите или создайте тему!", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var question = new Question
            {
                Id = Guid.NewGuid().ToString(),
                Text = txtQuestionText.Text,
                Type = cmbQuestionType.SelectedItem?.ToString() ?? "custom",
                Hint = txtHint.Text,
                ImagePath = txtImagePath.Text,
                Difficulty = (int)numLevel.Value,
                Topic = currentTopic.Name
            };

            var answers = new[] { txtAnswer1, txtAnswer2, txtAnswer3, txtAnswer4 };
            var checks = new[] { chkCorrect1, chkCorrect2, chkCorrect3, chkCorrect4 };

            for (int i = 0; i < 4; i++)
            {
                if (answers[i] != null && !string.IsNullOrWhiteSpace(answers[i].Text))
                {
                    question.Answers.Add(answers[i].Text);
                    if (checks[i] != null && checks[i].Checked)
                        question.CorrectIndex = question.Answers.Count - 1;
                }
            }

            if (question.Answers.Count == 0)
            {
                MessageBox.Show("Добавьте хотя бы один вариант ответа!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            currentTopic.Levels[question.Difficulty].Add(question);
            xmlManager.SaveTopic(currentTopic);

            MessageBox.Show("Вопрос добавлен!", "Успех",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadQuestions(null, null);
            ClearQuestionForm();
        }

        private void ClearQuestionForm()
        {
            txtQuestionText.Clear();
            txtHint.Clear();
            txtImagePath.Clear();
            txtAnswer1.Clear(); txtAnswer2.Clear(); txtAnswer3.Clear(); txtAnswer4.Clear();
            chkCorrect1.Checked = false; chkCorrect2.Checked = false;
            chkCorrect3.Checked = false; chkCorrect4.Checked = false;
        }

        private void btnBrowseImage_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog
            {
                Filter = "Изображения|*.jpg;*.jpeg;*.png;*.gif",
                Title = "Выберите изображение"
            };

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                // Сохраняем относительный путь
                string imageName = Path.GetFileName(dlg.FileName);
                txtImagePath.Text = "Resources/images/" + imageName;

                // Копируем файл в папку проекта
                string basePath = AppDomain.CurrentDomain.BaseDirectory;
                string destFolder = Path.Combine(basePath, "..", "..", "..", "Resources", "images");
                Directory.CreateDirectory(destFolder);
                string destPath = Path.Combine(destFolder, imageName);
                File.Copy(dlg.FileName, destPath, true);

                MessageBox.Show($"Изображение сохранено: {imageName}", "Успех",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnNewTopic_Click(object sender, EventArgs e)
        {
            var dlg = new InputDialog("Новая тема", "Введите название новой темы:");
            if (dlg.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(dlg.Result))
            {
                var newTopic = new Topic { Name = dlg.Result };
                xmlManager.SaveTopic(newTopic);
                LoadTopics();
                cmbTopics.SelectedItem = dlg.Result;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (currentTopic != null)
            {
                xmlManager.SaveTopic(currentTopic);
                MessageBox.Show("Изменения сохранены!", "Успех",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}