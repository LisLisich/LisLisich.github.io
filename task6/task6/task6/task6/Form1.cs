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
    public partial class Form1 : Form
    {
        private XmlManager xmlManager;
        private GameSession session;
        private Topic currentTopic;

        public Form1()
        {
            InitializeComponent();

            // Путь к XML-файлу (от bin\Debug вверх на 3 уровня к корню решения)
            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            string xmlPath = Path.Combine(basePath, "..", "..", "..", "questions.xml");

            xmlManager = new XmlManager(xmlPath);
            session = new GameSession();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadTopic("Обычаи");
            StartGame();
        }

        private void LoadTopic(string topicName)
        {
            var topics = xmlManager.LoadAllTopics();
            currentTopic = topics.FirstOrDefault(t => t.Name == topicName) ?? topics.FirstOrDefault();

            if (currentTopic != null)
            {
                lblTopic.Text = $"Тема: {currentTopic.Name}";
                lblLevel.Text = $"Уровень: {session.CurrentLevel}";
            }
        }

        private void StartGame()
        {
            if (currentTopic == null) return;

            var questions = currentTopic.GetQuestionsByLevel(session.CurrentLevel);
            if (questions.Count == 0)
            {
                MessageBox.Show("Нет вопросов для этого уровня!", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            session.GenerateSession(questions, count: 5);
            timerGame.Start();
            ShowCurrentQuestion();
            UpdateUI();
        }

        private void ShowCurrentQuestion()
        {
            var question = session.GetCurrentQuestion();
            if (question == null) return;

            lblQuestion.Text = question.Text;
            lblHint.Visible = false;
            lblHint.Text = "";
            txtAnswer.Text = "Введите ответ...";
            txtAnswer.ForeColor = Color.Gray;
            txtAnswer.Enabled = question.Type == "riddle" || question.Type == "proverb";
            btnSubmit.Enabled = true;
            btnNext.Enabled = false;
            flowLayoutPanelAnswers.Controls.Clear();

            // Загрузка изображения
            if (!string.IsNullOrEmpty(question.ImagePath))
            {
                try
                {
                    string resourceName = Path.GetFileNameWithoutExtension(question.ImagePath);
                    var resourceManager = Properties.Resources.ResourceManager;
                    object imgObj = resourceManager.GetObject(resourceName);

                    if (imgObj != null && imgObj is Image)
                    {
                        pbQuestionImage.Image = (Image)imgObj;
                        pbQuestionImage.Visible = true;
                        flowLayoutPanelAnswers.Location = new Point(16, 145);
                        flowLayoutPanelAnswers.Size = new Size(350, 200);
                    }
                    else
                    {
                        pbQuestionImage.Image = null;
                        pbQuestionImage.Visible = false;
                        flowLayoutPanelAnswers.Location = new Point(16, 145);
                        flowLayoutPanelAnswers.Size = new Size(550, 150);
                    }
                }
                catch
                {
                    pbQuestionImage.Image = null;
                    pbQuestionImage.Visible = false;
                    flowLayoutPanelAnswers.Location = new Point(16, 145);
                    flowLayoutPanelAnswers.Size = new Size(550, 150);
                }
            }
            else
            {
                pbQuestionImage.Image = null;
                pbQuestionImage.Visible = false;
                flowLayoutPanelAnswers.Location = new Point(16, 145);
                flowLayoutPanelAnswers.Size = new Size(550, 150);
            }

            if (question.Answers.Count > 0)
            {
                foreach (var ans in question.Answers)
                {
                    var btn = new RadioButton
                    {
                        Text = ans,
                        AutoSize = true,
                        Margin = new Padding(5),
                        Tag = question.Answers.IndexOf(ans)
                    };
                    flowLayoutPanelAnswers.Controls.Add(btn);
                }
            }

            progressBar.Value = (session.CurrentQuestionIndex * 100) / Math.Max(1, session.SessionQuestions.Count);
            lblProgressText.Text = $"Вопрос {session.CurrentQuestionIndex + 1}/{session.SessionQuestions.Count}";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var question = session.GetCurrentQuestion();
            if (question == null) return;

            int userAnswer = -1;

            foreach (RadioButton rb in flowLayoutPanelAnswers.Controls)
            {
                if (rb.Checked)
                {
                    userAnswer = (int)rb.Tag;
                    break;
                }
            }

            if (string.IsNullOrWhiteSpace(txtAnswer.Text) || (txtAnswer.ForeColor == Color.Gray && userAnswer == -1))
            {
                MessageBox.Show("Пожалуйста, выберите или введите ответ!", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!string.IsNullOrWhiteSpace(txtAnswer.Text) && txtAnswer.ForeColor == Color.Black)
            {
                var userText = txtAnswer.Text.Trim().ToLower();
                var correctText = question.Answers[question.CorrectIndex].ToLower();

                if (userText.Contains(correctText) || correctText.Contains(userText))
                {
                    session.AddScore(100.0 / session.SessionQuestions.Count);
                    MessageBox.Show("✓ Правильно!", "Результат",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"✗ Неправильно. Правильный ответ: {question.Answers[question.CorrectIndex]}",
                        "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (userAnswer == question.CorrectIndex)
            {
                session.AddScore(100.0 / session.SessionQuestions.Count);
                MessageBox.Show("✓ Правильно!", "Результат",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"✗ Неправильно. Правильный ответ: {question.Answers[question.CorrectIndex]}",
                    "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            btnSubmit.Enabled = false;
            btnNext.Enabled = true;
            UpdateUI();
        }

        private void btnHint_Click(object sender, EventArgs e)
        {
            var question = session.GetCurrentQuestion();
            if (question != null && !string.IsNullOrEmpty(question.Hint))
            {
                lblHint.Text = $"💡 {question.Hint}";
                lblHint.Visible = true;
                session.AddScore(-5);
                UpdateUI();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (session.NextQuestion())
            {
                ShowCurrentQuestion();
            }
            else
            {
                EndGame();
            }
        }

        private void timerGame_Tick(object sender, EventArgs e)
        {
            var remaining = session.GetRemainingTime();
            if (remaining.TotalSeconds <= 0)
            {
                timerGame.Stop();
                EndGame();
                return;
            }
            lblTimer.Text = $"{(int)remaining.Minutes:D2}:{(int)remaining.Seconds:D2}";

            if (remaining.TotalMinutes < 2)
                lblTimer.ForeColor = Color.Red;
            else
                lblTimer.ForeColor = Color.Black;
        }

        private void EndGame()
        {
            timerGame.Stop();
            session.IsFinished = true;

            int finalScore = (int)Math.Round((double)session.Score);
            MessageBox.Show($"Игра окончена!\nВаш счёт: {finalScore}/100",
                "Результат", MessageBoxButtons.OK,
                finalScore >= 80 ? MessageBoxIcon.Information : MessageBoxIcon.Warning);

            if (session.CanAdvanceToNextLevel() && session.CurrentLevel < 3)
            {
                var result = MessageBox.Show(
                    $"Поздравляем! Вы набрали {finalScore} баллов и можете перейти на уровень {session.CurrentLevel + 1}.\nПерейти?",
                    "Новый уровень", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    session.CurrentLevel++;
                    lblLevel.Text = $"Уровень: {session.CurrentLevel}";
                    StartGame();
                    return;
                }
            }
            else if (session.CurrentLevel == 3 && session.CanAdvanceToNextLevel())
            {
                MessageBox.Show("🎉 Вы прошли все уровни темы! Поздравляем!",
                    "Победа!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

            UpdateUI();
        }

        private void UpdateUI()
        {
            lblScore.Text = $"Счёт: {(int)Math.Round((double)session.Score)}";
            progressBar.Refresh();
        }

        private void txtAnswer_Enter(object sender, EventArgs e)
        {
            if (txtAnswer.Text == "Введите ответ..." && txtAnswer.ForeColor == Color.Gray)
            {
                txtAnswer.Text = "";
                txtAnswer.ForeColor = Color.Black;
            }
        }

        private void txtAnswer_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAnswer.Text))
            {
                txtAnswer.Text = "Введите ответ...";
                txtAnswer.ForeColor = Color.Gray;
            }
        }

        private void новаяИграToolStripMenuItem_Click(object sender, EventArgs e)
        {
            session = new GameSession { CurrentLevel = 1 };
            StartGame();
        }

        private void выборТемыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var topics = xmlManager.LoadAllTopics();
            var topicNames = topics.Select(t => t.Name).Distinct().ToArray();

            var dlg = new Form
            {
                Text = "Выбор темы",
                Size = new Size(300, 200),
                StartPosition = FormStartPosition.CenterParent,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false,
                MinimizeBox = false
            };

            var lst = new ListBox { Dock = DockStyle.Fill };
            lst.Items.AddRange(topicNames);

            var btnOK = new Button { Text = "OK", DialogResult = DialogResult.OK, Location = new Point(100, 150) };
            var btnCancel = new Button { Text = "Отмена", DialogResult = DialogResult.Cancel, Location = new Point(180, 150) };

            dlg.Controls.Add(lst);
            dlg.Controls.Add(btnOK);
            dlg.Controls.Add(btnCancel);
            dlg.AcceptButton = btnOK;
            dlg.CancelButton = btnCancel;

            if (dlg.ShowDialog() == DialogResult.OK && lst.SelectedItem != null)
            {
                LoadTopic(lst.SelectedItem.ToString());
                session = new GameSession { CurrentLevel = 1 };
                StartGame();
            }
        }

        private void панельАдминистратораToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var adminForm = new AdminForm(xmlManager);
            if (adminForm.ShowDialog() == DialogResult.OK)
            {
                LoadTopic(currentTopic?.Name ?? "Обычаи");
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}