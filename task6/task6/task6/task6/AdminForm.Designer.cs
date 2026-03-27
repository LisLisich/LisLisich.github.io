namespace task6
{
    partial class AdminForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTopic = new System.Windows.Forms.Label();
            this.cmbTopics = new System.Windows.Forms.ComboBox();
            this.btnNewTopic = new System.Windows.Forms.Button();
            this.lblLevel = new System.Windows.Forms.Label();
            this.numLevel = new System.Windows.Forms.NumericUpDown();
            this.lstQuestions = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBrowseImage = new System.Windows.Forms.Button();
            this.txtImagePath = new System.Windows.Forms.TextBox();
            this.lblImage = new System.Windows.Forms.Label();
            this.txtHint = new System.Windows.Forms.TextBox();
            this.lblHint = new System.Windows.Forms.Label();
            this.cmbQuestionType = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.txtQuestionText = new System.Windows.Forms.TextBox();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkCorrect4 = new System.Windows.Forms.CheckBox();
            this.txtAnswer4 = new System.Windows.Forms.TextBox();
            this.chkCorrect3 = new System.Windows.Forms.CheckBox();
            this.txtAnswer3 = new System.Windows.Forms.TextBox();
            this.chkCorrect2 = new System.Windows.Forms.CheckBox();
            this.txtAnswer2 = new System.Windows.Forms.TextBox();
            this.chkCorrect1 = new System.Windows.Forms.CheckBox();
            this.txtAnswer1 = new System.Windows.Forms.TextBox();
            this.btnAddQuestion = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTopic
            // 
            this.lblTopic.AutoSize = true;
            this.lblTopic.Location = new System.Drawing.Point(12, 15);
            this.lblTopic.Name = "lblTopic";
            this.lblTopic.Size = new System.Drawing.Size(43, 13);
            this.lblTopic.TabIndex = 0;
            this.lblTopic.Text = "Тема:";
            // 
            // cmbTopics
            // 
            this.cmbTopics.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTopics.FormattingEnabled = true;
            this.cmbTopics.Location = new System.Drawing.Point(61, 12);
            this.cmbTopics.Name = "cmbTopics";
            this.cmbTopics.Size = new System.Drawing.Size(200, 21);
            this.cmbTopics.TabIndex = 1;
            this.cmbTopics.SelectedIndexChanged += new System.EventHandler(this.cmbTopics_SelectedIndexChanged);
            // 
            // btnNewTopic
            // 
            this.btnNewTopic.Location = new System.Drawing.Point(267, 10);
            this.btnNewTopic.Name = "btnNewTopic";
            this.btnNewTopic.Size = new System.Drawing.Size(100, 23);
            this.btnNewTopic.TabIndex = 2;
            this.btnNewTopic.Text = "Новая тема";
            this.btnNewTopic.UseVisualStyleBackColor = true;
            this.btnNewTopic.Click += new System.EventHandler(this.btnNewTopic_Click);
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(12, 45);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(52, 13);
            this.lblLevel.TabIndex = 3;
            this.lblLevel.Text = "Уровень:";
            // 
            // numLevel
            // 
            this.numLevel.Location = new System.Drawing.Point(70, 43);
            this.numLevel.Maximum = new decimal(new int[] { 3, 0, 0, 0 });
            this.numLevel.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numLevel.Name = "numLevel";
            this.numLevel.Size = new System.Drawing.Size(50, 20);
            this.numLevel.TabIndex = 4;
            this.numLevel.Value = new decimal(new int[] { 1, 0, 0, 0 });
            this.numLevel.ValueChanged += new System.EventHandler(this.LoadQuestions);
            // 
            // lstQuestions
            // 
            this.lstQuestions.FormattingEnabled = true;
            this.lstQuestions.Location = new System.Drawing.Point(15, 80);
            this.lstQuestions.Name = "lstQuestions";
            this.lstQuestions.Size = new System.Drawing.Size(352, 355);
            this.lstQuestions.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBrowseImage);
            this.groupBox1.Controls.Add(this.txtImagePath);
            this.groupBox1.Controls.Add(this.lblImage);
            this.groupBox1.Controls.Add(this.txtHint);
            this.groupBox1.Controls.Add(this.lblHint);
            this.groupBox1.Controls.Add(this.cmbQuestionType);
            this.groupBox1.Controls.Add(this.lblType);
            this.groupBox1.Controls.Add(this.txtQuestionText);
            this.groupBox1.Controls.Add(this.lblQuestion);
            this.groupBox1.Location = new System.Drawing.Point(380, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 180);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Вопрос";
            // 
            // btnBrowseImage
            // 
            this.btnBrowseImage.Location = new System.Drawing.Point(320, 145);
            this.btnBrowseImage.Name = "btnBrowseImage";
            this.btnBrowseImage.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseImage.TabIndex = 8;
            this.btnBrowseImage.Text = "Обзор...";
            this.btnBrowseImage.UseVisualStyleBackColor = true;
            this.btnBrowseImage.Click += new System.EventHandler(this.btnBrowseImage_Click);
            // 
            // txtImagePath
            // 
            this.txtImagePath.Location = new System.Drawing.Point(80, 147);
            this.txtImagePath.Name = "txtImagePath";
            this.txtImagePath.Size = new System.Drawing.Size(234, 20);
            this.txtImagePath.TabIndex = 7;
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.Location = new System.Drawing.Point(6, 150);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(68, 13);
            this.lblImage.TabIndex = 6;
            this.lblImage.Text = "Изображение:";
            // 
            // txtHint
            // 
            this.txtHint.Location = new System.Drawing.Point(80, 121);
            this.txtHint.Name = "txtHint";
            this.txtHint.Size = new System.Drawing.Size(315, 20);
            this.txtHint.TabIndex = 5;
            // 
            // lblHint
            // 
            this.lblHint.AutoSize = true;
            this.lblHint.Location = new System.Drawing.Point(6, 124);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(65, 13);
            this.lblHint.TabIndex = 4;
            this.lblHint.Text = "Подсказка:";
            // 
            // cmbQuestionType
            // 
            this.cmbQuestionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQuestionType.FormattingEnabled = true;
            this.cmbQuestionType.Items.AddRange(new object[] { "riddle", "proverb", "custom" });
            this.cmbQuestionType.Location = new System.Drawing.Point(80, 94);
            this.cmbQuestionType.Name = "cmbQuestionType";
            this.cmbQuestionType.Size = new System.Drawing.Size(121, 21);
            this.cmbQuestionType.TabIndex = 3;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(6, 97);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(31, 13);
            this.lblType.TabIndex = 2;
            this.lblType.Text = "Тип:";
            // 
            // txtQuestionText
            // 
            this.txtQuestionText.Location = new System.Drawing.Point(80, 25);
            this.txtQuestionText.Multiline = true;
            this.txtQuestionText.Name = "txtQuestionText";
            this.txtQuestionText.Size = new System.Drawing.Size(315, 60);
            this.txtQuestionText.TabIndex = 1;
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(6, 28);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(54, 13);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "Вопрос:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkCorrect4);
            this.groupBox2.Controls.Add(this.txtAnswer4);
            this.groupBox2.Controls.Add(this.chkCorrect3);
            this.groupBox2.Controls.Add(this.txtAnswer3);
            this.groupBox2.Controls.Add(this.chkCorrect2);
            this.groupBox2.Controls.Add(this.txtAnswer2);
            this.groupBox2.Controls.Add(this.chkCorrect1);
            this.groupBox2.Controls.Add(this.txtAnswer1);
            this.groupBox2.Location = new System.Drawing.Point(380, 198);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(400, 140);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Варианты ответов";
            // 
            // chkCorrect4
            // 
            this.chkCorrect4.AutoSize = true;
            this.chkCorrect4.Location = new System.Drawing.Point(350, 110);
            this.chkCorrect4.Name = "chkCorrect4";
            this.chkCorrect4.Size = new System.Drawing.Size(44, 17);
            this.chkCorrect4.TabIndex = 7;
            this.chkCorrect4.Text = "✓";
            this.chkCorrect4.UseVisualStyleBackColor = true;
            // 
            // txtAnswer4
            // 
            this.txtAnswer4.Location = new System.Drawing.Point(10, 108);
            this.txtAnswer4.Name = "txtAnswer4";
            this.txtAnswer4.Size = new System.Drawing.Size(334, 20);
            this.txtAnswer4.TabIndex = 6;
            // 
            // chkCorrect3
            // 
            this.chkCorrect3.AutoSize = true;
            this.chkCorrect3.Location = new System.Drawing.Point(350, 84);
            this.chkCorrect3.Name = "chkCorrect3";
            this.chkCorrect3.Size = new System.Drawing.Size(44, 17);
            this.chkCorrect3.TabIndex = 5;
            this.chkCorrect3.Text = "✓";
            this.chkCorrect3.UseVisualStyleBackColor = true;
            // 
            // txtAnswer3
            // 
            this.txtAnswer3.Location = new System.Drawing.Point(10, 82);
            this.txtAnswer3.Name = "txtAnswer3";
            this.txtAnswer3.Size = new System.Drawing.Size(334, 20);
            this.txtAnswer3.TabIndex = 4;
            // 
            // chkCorrect2
            // 
            this.chkCorrect2.AutoSize = true;
            this.chkCorrect2.Location = new System.Drawing.Point(350, 58);
            this.chkCorrect2.Name = "chkCorrect2";
            this.chkCorrect2.Size = new System.Drawing.Size(44, 17);
            this.chkCorrect2.TabIndex = 3;
            this.chkCorrect2.Text = "✓";
            this.chkCorrect2.UseVisualStyleBackColor = true;
            // 
            // txtAnswer2
            // 
            this.txtAnswer2.Location = new System.Drawing.Point(10, 56);
            this.txtAnswer2.Name = "txtAnswer2";
            this.txtAnswer2.Size = new System.Drawing.Size(334, 20);
            this.txtAnswer2.TabIndex = 2;
            // 
            // chkCorrect1
            // 
            this.chkCorrect1.AutoSize = true;
            this.chkCorrect1.Location = new System.Drawing.Point(350, 32);
            this.chkCorrect1.Name = "chkCorrect1";
            this.chkCorrect1.Size = new System.Drawing.Size(44, 17);
            this.chkCorrect1.TabIndex = 1;
            this.chkCorrect1.Text = "✓";
            this.chkCorrect1.UseVisualStyleBackColor = true;
            // 
            // txtAnswer1
            // 
            this.txtAnswer1.Location = new System.Drawing.Point(10, 30);
            this.txtAnswer1.Name = "txtAnswer1";
            this.txtAnswer1.Size = new System.Drawing.Size(334, 20);
            this.txtAnswer1.TabIndex = 0;
            // 
            // btnAddQuestion
            // 
            this.btnAddQuestion.Location = new System.Drawing.Point(380, 350);
            this.btnAddQuestion.Name = "btnAddQuestion";
            this.btnAddQuestion.Size = new System.Drawing.Size(150, 30);
            this.btnAddQuestion.TabIndex = 8;
            this.btnAddQuestion.Text = "Добавить вопрос";
            this.btnAddQuestion.UseVisualStyleBackColor = true;
            this.btnAddQuestion.Click += new System.EventHandler(this.btnAddQuestion_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(630, 350);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 30);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Сохранить изменения";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAddQuestion);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstQuestions);
            this.Controls.Add(this.numLevel);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.btnNewTopic);
            this.Controls.Add(this.cmbTopics);
            this.Controls.Add(this.lblTopic);
            this.Name = "AdminForm";
            this.Text = "Панель администратора";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTopic;
        private System.Windows.Forms.ComboBox cmbTopics;
        private System.Windows.Forms.Button btnNewTopic;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.NumericUpDown numLevel;
        private System.Windows.Forms.ListBox lstQuestions;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBrowseImage;
        private System.Windows.Forms.TextBox txtImagePath;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.TextBox txtHint;
        private System.Windows.Forms.Label lblHint;
        private System.Windows.Forms.ComboBox cmbQuestionType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.TextBox txtQuestionText;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkCorrect4;
        private System.Windows.Forms.TextBox txtAnswer4;
        private System.Windows.Forms.CheckBox chkCorrect3;
        private System.Windows.Forms.TextBox txtAnswer3;
        private System.Windows.Forms.CheckBox chkCorrect2;
        private System.Windows.Forms.TextBox txtAnswer2;
        private System.Windows.Forms.CheckBox chkCorrect1;
        private System.Windows.Forms.TextBox txtAnswer1;
        private System.Windows.Forms.Button btnAddQuestion;
        private System.Windows.Forms.Button btnSave;
    }
}