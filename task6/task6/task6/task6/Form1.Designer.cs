namespace task6
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTopic = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnHint = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.flowLayoutPanelAnswers = new System.Windows.Forms.FlowLayoutPanel();
            this.lblHint = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.timerGame = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новаяИграToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выборТемыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.панельАдминистратораToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblProgressText = new System.Windows.Forms.Label();
            this.pbQuestionImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuestionImage)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(12, 35);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(280, 26);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Загадки и обычаи на Руси";
            // 
            // lblTopic
            // 
            this.lblTopic.AutoSize = true;
            this.lblTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTopic.Location = new System.Drawing.Point(12, 70);
            this.lblTopic.Name = "lblTopic";
            this.lblTopic.Size = new System.Drawing.Size(100, 17);
            this.lblTopic.TabIndex = 1;
            this.lblTopic.Text = "Тема: Обычаи";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblLevel.Location = new System.Drawing.Point(150, 70);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(80, 17);
            this.lblLevel.TabIndex = 2;
            this.lblLevel.Text = "Уровень: 1";
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblTimer.ForeColor = System.Drawing.Color.Red;
            this.lblTimer.Location = new System.Drawing.Point(680, 35);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(78, 20);
            this.lblTimer.TabIndex = 3;
            this.lblTimer.Text = "10:00";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblScore.Location = new System.Drawing.Point(680, 70);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(62, 18);
            this.lblScore.TabIndex = 4;
            this.lblScore.Text = "Счёт: 0";
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblQuestion.Location = new System.Drawing.Point(12, 110);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(140, 20);
            this.lblQuestion.TabIndex = 5;
            this.lblQuestion.Text = "Текст вопроса...";
            // 
            // pbQuestionImage
            // 
            this.pbQuestionImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbQuestionImage.Location = new System.Drawing.Point(580, 110);
            this.pbQuestionImage.Name = "pbQuestionImage";
            this.pbQuestionImage.Size = new System.Drawing.Size(200, 200);
            this.pbQuestionImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbQuestionImage.TabIndex = 16;
            this.pbQuestionImage.TabStop = false;
            this.pbQuestionImage.Visible = false;
            // 
            // flowLayoutPanelAnswers
            // 
            this.flowLayoutPanelAnswers.AutoScroll = true;
            this.flowLayoutPanelAnswers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanelAnswers.Location = new System.Drawing.Point(16, 145);
            this.flowLayoutPanelAnswers.Name = "flowLayoutPanelAnswers";
            this.flowLayoutPanelAnswers.Size = new System.Drawing.Size(550, 150);
            this.flowLayoutPanelAnswers.TabIndex = 11;
            // 
            // txtAnswer
            // 
            this.txtAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtAnswer.Location = new System.Drawing.Point(16, 315);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(400, 24);
            this.txtAnswer.TabIndex = 7;
            this.txtAnswer.Text = "Введите ответ...";
            this.txtAnswer.ForeColor = System.Drawing.Color.Gray;
            this.txtAnswer.Enter += new System.EventHandler(this.txtAnswer_Enter);
            this.txtAnswer.Leave += new System.EventHandler(this.txtAnswer_Leave);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSubmit.Location = new System.Drawing.Point(430, 313);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(130, 30);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Ответить";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnHint
            // 
            this.btnHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnHint.Location = new System.Drawing.Point(16, 355);
            this.btnHint.Name = "btnHint";
            this.btnHint.Size = new System.Drawing.Size(130, 30);
            this.btnHint.TabIndex = 9;
            this.btnHint.Text = "💡 Подсказка";
            this.btnHint.UseVisualStyleBackColor = true;
            this.btnHint.Click += new System.EventHandler(this.btnHint_Click);
            // 
            // btnNext
            // 
            this.btnNext.Enabled = false;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnNext.Location = new System.Drawing.Point(630, 355);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(130, 30);
            this.btnNext.TabIndex = 10;
            this.btnNext.Text = "Далее →";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblHint
            // 
            this.lblHint.AutoSize = true;
            this.lblHint.BackColor = System.Drawing.Color.LightYellow;
            this.lblHint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblHint.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblHint.Location = new System.Drawing.Point(16, 395);
            this.lblHint.Name = "lblHint";
            this.lblHint.Padding = new System.Windows.Forms.Padding(10);
            this.lblHint.Size = new System.Drawing.Size(2, 2);
            this.lblHint.TabIndex = 12;
            this.lblHint.Visible = false;
            // 
            // lblProgressText
            // 
            this.lblProgressText.AutoSize = true;
            this.lblProgressText.Location = new System.Drawing.Point(16, 435);
            this.lblProgressText.Name = "lblProgressText";
            this.lblProgressText.Size = new System.Drawing.Size(60, 13);
            this.lblProgressText.TabIndex = 15;
            this.lblProgressText.Text = "Вопрос 1/5";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(100, 430);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(660, 23);
            this.progressBar.TabIndex = 13;
            // 
            // timerGame
            // 
            this.timerGame.Interval = 1000;
            this.timerGame.Tick += new System.EventHandler(this.timerGame_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новаяИграToolStripMenuItem,
            this.выборТемыToolStripMenuItem,
            this.панельАдминистратораToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // новаяИграToolStripMenuItem
            // 
            this.новаяИграToolStripMenuItem.Name = "новаяИграToolStripMenuItem";
            this.новаяИграToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.новаяИграToolStripMenuItem.Text = "Новая игра";
            this.новаяИграToolStripMenuItem.Click += new System.EventHandler(this.новаяИграToolStripMenuItem_Click);
            // 
            // выборТемыToolStripMenuItem
            // 
            this.выборТемыToolStripMenuItem.Name = "выборТемыToolStripMenuItem";
            this.выборТемыToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.выборТемыToolStripMenuItem.Text = "Выбор темы";
            this.выборТемыToolStripMenuItem.Click += new System.EventHandler(this.выборТемыToolStripMenuItem_Click);
            // 
            // панельАдминистратораToolStripMenuItem
            // 
            this.панельАдминистратораToolStripMenuItem.Name = "панельАдминистратораToolStripMenuItem";
            this.панельАдминистратораToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.панельАдминистратораToolStripMenuItem.Text = "Панель администратора";
            this.панельАдминистратораToolStripMenuItem.Click += new System.EventHandler(this.панельАдминистратораToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 470);
            this.Controls.Add(this.pbQuestionImage);
            this.Controls.Add(this.lblProgressText);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.lblHint);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnHint);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.flowLayoutPanelAnswers);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.lblTopic);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Загадки и обычаи на Руси";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbQuestionImage)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTopic;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.PictureBox pbQuestionImage;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnHint;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelAnswers;
        private System.Windows.Forms.Label lblHint;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Timer timerGame;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новаяИграToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выборТемыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem панельАдминистратораToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.Label lblProgressText;
    }
}