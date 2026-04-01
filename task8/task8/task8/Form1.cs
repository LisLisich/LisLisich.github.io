using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace task8
{
    public partial class Form1 : Form
    {
        private int gridSize = 4;
        private int pairsFound = 0;
        private int totalPairs = 0;
        private List<int> cardValues = new List<int>();
        private List<PictureBox> openCards = new List<PictureBox>();
        private bool isGameActive = false;
        private System.Windows.Forms.Timer gameTimer;
        private int timeLeft = 0;
        private int moveCount = 0;
        private string currentLogin = "";
        private readonly string resultsFile = "results.bin";
        private int gameTimeLimit = 120;
        private Color cardBackColor = Color.FromArgb(255, 255, 255);
        private Color cardFrameColor = Color.FromArgb(0, 102, 204);

        // Красивые цвета для карт
        private Color[] cardColors = new Color[]
        {
            Color.FromArgb(255, 99, 71),   // Красный
            Color.FromArgb(60, 179, 113),  // Зеленый
            Color.FromArgb(30, 144, 255),  // Синий
            Color.FromArgb(255, 215, 0),   // Золотой
            Color.FromArgb(255, 165, 0),   // Оранжевый
            Color.FromArgb(148, 0, 211),   // Фиолетовый
            Color.FromArgb(255, 20, 147),  // Розовый
            Color.FromArgb(0, 191, 255),   // Голубой
            Color.FromArgb(50, 205, 50),   // Лайм
            Color.FromArgb(255, 105, 180), // Hot Pink
            Color.FromArgb(64, 224, 208),  // Бирюзовый
            Color.FromArgb(220, 20, 60),   // Crimson
        };

        public Form1()
        {
            InitializeComponent();
            InitializeTimer();
            UpdateStatus();
            ApplyModernStyle();
        }

        private void ApplyModernStyle()
        {
            this.BackColor = Color.FromArgb(240, 248, 255);
            this.Font = new Font("Segoe UI", 10F);
        }

        private void InitializeTimer()
        {
            gameTimer = new System.Windows.Forms.Timer();
            gameTimer.Interval = 1000;
            gameTimer.Tick += GameTimer_Tick;
        }

        #region Menu Events

        private void менюФайлВыходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void менюНастройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowSettings();
        }

        private void менюСправкаОИгреToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Игра «Парные картинки».\n\n" +
                "Правила:\n" +
                "1. Откройте две клетки.\n" +
                "2. Если картинки одинаковы — они исчезают.\n" +
                "3. Если разные — они остаются открытыми.\n" +
                "4. Следующий щелчок закроет две открытые клетки и откроет новую.\n" +
                "5. Найдите все пары за отведенное время.",
                "Справка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void менюРезультатыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowResults();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            using (var regForm = new Form2())
            {
                var result = regForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txtLogin.Focus();
                }
            }
        }

        #endregion

        #region Game Logic

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLogin.Text))
            {
                MessageBox.Show("Введите логин для начала игры!\nИли зарегистрируйтесь.", "Авторизация",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLogin.Focus();
                return;
            }

            currentLogin = txtLogin.Text.Trim();
            StartGame();
        }

        private void StartGame()
        {
            gameBoard.Controls.Clear();
            openCards.Clear();
            pairsFound = 0;
            moveCount = 0;
            timeLeft = gameTimeLimit;
            isGameActive = true;
            totalPairs = (gridSize * gridSize) / 2;

            lblTimer.Text = $"Время: {timeLeft}";
            lblScore.Text = $"Пары: 0/{totalPairs}";
            lblMoves.Text = $"Ходы: 0";
            btnStartGame.Enabled = false;
            txtLogin.Enabled = false;

            GenerateCards();
            gameTimer.Start();
        }

        private void GenerateCards()
        {
            gameBoard.ColumnCount = gridSize;
            gameBoard.RowCount = gridSize;

            gameBoard.ColumnStyles.Clear();
            gameBoard.RowStyles.Clear();
            for (int i = 0; i < gridSize; i++)
            {
                gameBoard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / gridSize));
                gameBoard.RowStyles.Add(new RowStyle(SizeType.Percent, 100f / gridSize));
            }

            cardValues.Clear();
            for (int i = 0; i < totalPairs; i++)
            {
                cardValues.Add(i);
                cardValues.Add(i);
            }

            var rng = new Random();
            cardValues = cardValues.OrderBy(x => rng.Next()).ToList();

            for (int i = 0; i < gridSize * gridSize; i++)
            {
                var pb = new PictureBox
                {
                    Dock = DockStyle.Fill,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Tag = cardValues[i],
                    BackColor = cardBackColor,
                    BorderStyle = BorderStyle.None,
                    Name = $"card_{i}",
                    Cursor = Cursors.Hand,
                    Margin = new Padding(3)
                };

                pb.Image = CreateCardImage(-1);
                pb.Click += Card_Click;
                pb.MouseEnter += (s, e) => { if (isGameActive) pb.BackColor = Color.FromArgb(230, 240, 255); };
                pb.MouseLeave += (s, e) => { if (pb.Image != null && (int)pb.Tag == -1) pb.BackColor = cardBackColor; };

                gameBoard.Controls.Add(pb, i % gridSize, i / gridSize);
            }
        }

        private void Card_Click(object sender, EventArgs e)
        {
            if (!isGameActive) return;

            PictureBox pb = sender as PictureBox;
            if (pb == null) return;
            if (pb.Image == null) return;
            if (openCards.Contains(pb)) return;

            if (openCards.Count == 2)
            {
                foreach (var openCard in openCards)
                {
                    openCard.Image = CreateCardImage(-1);
                    openCard.BackColor = cardBackColor;
                }
                openCards.Clear();
            }

            int val = (int)pb.Tag;
            pb.Image = CreateCardImage(val);
            pb.BackColor = Color.White;
            openCards.Add(pb);
            moveCount++;
            lblMoves.Text = $"Ходы: {moveCount}";

            if (openCards.Count == 2)
            {
                int val1 = (int)openCards[0].Tag;
                int val2 = (int)openCards[1].Tag;

                if (val1 == val2)
                {
                    pairsFound++;
                    lblScore.Text = $"Пары: {pairsFound}/{totalPairs}";

                    // Сохраняем ссылки на карточки в локальные переменные
                    PictureBox card1 = openCards[0];
                    PictureBox card2 = openCards[1];

                    System.Windows.Forms.Timer hideTimer = new System.Windows.Forms.Timer();
                    hideTimer.Interval = 500;
                    hideTimer.Tick += (s, args) =>
                    {
                        // Используем сохранённые переменные вместо обращения к списку
                        if (card1 != null && !card1.IsDisposed)
                            card1.Visible = false;
                        if (card2 != null && !card2.IsDisposed)
                            card2.Visible = false;
                        openCards.Clear();
                        hideTimer.Stop();

                        if (pairsFound == totalPairs)
                        {
                            EndGame(true);
                        }
                    };
                    hideTimer.Start();
                }
            }
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft--;
                lblTimer.Text = $"Время: {timeLeft}";

                if (timeLeft <= 10)
                    lblTimer.ForeColor = Color.Red;
                else
                    lblTimer.ForeColor = Color.FromArgb(0, 102, 204);
            }
            else
            {
                EndGame(false);
            }
        }

        private void EndGame(bool win)
        {
            isGameActive = false;
            gameTimer.Stop();
            btnStartGame.Enabled = true;
            txtLogin.Enabled = true;

            if (win)
            {
                int timeSpent = gameTimeLimit - timeLeft;
                MessageBox.Show($"🎉 Победа!\n\nВремя: {timeSpent} сек.\nХодов: {moveCount}\n\nОтличный результат!",
                    "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SaveResult(currentLogin, timeSpent, moveCount, win);
            }
            else
            {
                MessageBox.Show("⏰ Время вышло!\nНе расстраивайтесь, попробуйте еще раз!",
                    "Проигрыш", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                SaveResult(currentLogin, gameTimeLimit, moveCount, win);
            }
        }

        #endregion

        #region Graphics Helper

        private Bitmap CreateCardImage(int value)
        {
            Bitmap bmp = new Bitmap(100, 100);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.Clear(cardBackColor);

                if (value == -1)
                {
                    // Рубашка карты с градиентом
                    using (LinearGradientBrush brush = new LinearGradientBrush(
                        new Point(0, 0), new Point(100, 100),
                        Color.FromArgb(100, 150, 200),
                        Color.FromArgb(150, 200, 255)))
                    {
                        g.FillRectangle(brush, 0, 0, 100, 100);
                    }

                    using (Pen pen = new Pen(Color.FromArgb(50, 100, 150), 2))
                    {
                        g.DrawRectangle(pen, 2, 2, 96, 96);
                    }

                    using (Font font = new Font("Arial", 40, FontStyle.Bold))
                    {
                        using (Brush brush = new SolidBrush(Color.FromArgb(80, 120, 160)))
                        {
                            StringFormat sf = new StringFormat();
                            sf.Alignment = StringAlignment.Center;
                            sf.LineAlignment = StringAlignment.Center;
                            g.DrawString("?", font, brush, new RectangleF(0, 0, 100, 100), sf);
                        }
                    }
                }
                else
                {
                    // Лицо карты с красивым кругом
                    Color cardColor = cardColors[value % cardColors.Length];

                    using (LinearGradientBrush brush = new LinearGradientBrush(
                        new Point(10, 10), new Point(90, 90),
                        cardColor,
                        ControlPaint.Light(cardColor, 0.2f)))
                    {
                        g.FillEllipse(brush, 10, 10, 80, 80);
                    }

                    using (Pen pen = new Pen(ControlPaint.Dark(cardColor), 3))
                    {
                        g.DrawEllipse(pen, 10, 10, 80, 80);
                    }

                    // Тень для цифры
                    using (Font font = new Font("Arial", 28, FontStyle.Bold))
                    {
                        using (Brush shadowBrush = new SolidBrush(Color.FromArgb(100, Color.Black)))
                        {
                            StringFormat sf = new StringFormat();
                            sf.Alignment = StringAlignment.Center;
                            sf.LineAlignment = StringAlignment.Center;
                            g.DrawString(value.ToString(), font, shadowBrush, new PointF(42, 37));
                        }

                        using (Brush brush = new SolidBrush(Color.White))
                        {
                            StringFormat sf = new StringFormat();
                            sf.Alignment = StringAlignment.Center;
                            sf.LineAlignment = StringAlignment.Center;
                            g.DrawString(value.ToString(), font, brush, new PointF(40, 35));
                        }
                    }
                }
            }
            return bmp;
        }

        #endregion

        #region Settings & Data

        private void ShowSettings()
        {
            using (var form = new Form())
            {
                form.Text = "Настройки игры";
                form.Size = new Size(350, 280);
                form.StartPosition = FormStartPosition.CenterScreen;
                form.FormBorderStyle = FormBorderStyle.FixedDialog;
                form.MaximizeBox = false;
                form.BackColor = Color.FromArgb(240, 248, 255);

                var lblSize = new Label { Text = "Размер поля:", Location = new Point(20, 20), AutoSize = true, Font = new Font("Segoe UI", 10F, FontStyle.Bold) };
                var cmbSize = new ComboBox { Location = new Point(20, 45), Width = 280, Font = new Font("Segoe UI", 10F) };
                cmbSize.Items.AddRange(new object[] { "4x4 (Легко)", "6x6 (Средне)", "8x8 (Сложно)" });
                cmbSize.SelectedIndex = gridSize == 4 ? 0 : (gridSize == 6 ? 1 : 2);

                var lblTime = new Label { Text = "Время (секунд):", Location = new Point(20, 85), AutoSize = true, Font = new Font("Segoe UI", 10F, FontStyle.Bold) };
                var numTime = new NumericUpDown { Location = new Point(20, 110), Width = 280, Minimum = 30, Maximum = 600, Value = gameTimeLimit, Font = new Font("Segoe UI", 10F) };

                var lblColor = new Label { Text = "Цвет карт:", Location = new Point(20, 150), AutoSize = true, Font = new Font("Segoe UI", 10F, FontStyle.Bold) };

                var btnSave = new Button { Text = "Сохранить настройки", Location = new Point(20, 190), Width = 280, Height = 40 };
                btnSave.BackColor = Color.FromArgb(0, 153, 0);
                btnSave.ForeColor = Color.White;
                btnSave.FlatStyle = FlatStyle.Flat;
                btnSave.FlatAppearance.BorderSize = 0;
                btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

                btnSave.Click += (s, e) =>
                {
                    if (cmbSize.SelectedIndex == 0) gridSize = 4;
                    else if (cmbSize.SelectedIndex == 1) gridSize = 6;
                    else gridSize = 8;
                    gameTimeLimit = (int)numTime.Value;
                    form.DialogResult = DialogResult.OK;
                };

                form.Controls.AddRange(new Control[] { lblSize, cmbSize, lblTime, numTime, lblColor, btnSave });
                form.AcceptButton = btnSave;
                form.ShowDialog();
            }
        }

        private void SaveResult(string login, int timeSpent, int moves, bool win)
        {
            try
            {
                using (var fs = new FileStream(resultsFile, FileMode.Append, FileAccess.Write))
                using (var bw = new BinaryWriter(fs))
                {
                    bw.Write(login);
                    bw.Write(timeSpent);
                    bw.Write(moves);
                    bw.Write(win);
                    bw.Write(DateTime.Now.ToBinary());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения: {ex.Message}");
            }
        }

        private void ShowResults()
        {
            if (string.IsNullOrWhiteSpace(txtLogin.Text))
            {
                MessageBox.Show("Введите логин для просмотра результатов.");
                return;
            }
            string login = txtLogin.Text.Trim();
            List<string> lines = new List<string>();

            try
            {
                if (File.Exists(resultsFile))
                {
                    using (var fs = new FileStream(resultsFile, FileMode.Open, FileAccess.Read))
                    using (var br = new BinaryReader(fs))
                    {
                        while (fs.Position < fs.Length)
                        {
                            string l = br.ReadString();
                            int t = br.ReadInt32();
                            int m = br.ReadInt32();
                            bool w = br.ReadBoolean();
                            long dt = br.ReadInt64();
                            DateTime date = DateTime.FromBinary(dt);

                            if (l == login)
                            {
                                string status = w ? "✅ Победа" : "❌ Поражение";
                                lines.Add($"{date.ToShortDateString()} {date.ToShortTimeString()} | Время: {t}с | Ходы: {m} | {status}");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка чтения: {ex.Message}");
                return;
            }

            if (lines.Count == 0)
            {
                MessageBox.Show($"Нет результатов для игрока {login}.", "Результаты", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"📊 История игрока {login}:\n\n" + string.Join("\n", lines), "Результаты игры",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void UpdateStatus()
        {
            lblTimer.Text = $"Время: {gameTimeLimit}";
            lblScore.Text = "Пары: 0";
            lblMoves.Text = "Ходы: 0";
            lblTimer.ForeColor = Color.FromArgb(0, 102, 204);
        }

        #endregion
    }
}