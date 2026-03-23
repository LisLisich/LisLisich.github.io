namespace task5
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            // Основные элементы управления
            this.gbDictionary = new System.Windows.Forms.GroupBox();
            this.btnSelectDict = new System.Windows.Forms.Button();
            this.lblDictPath = new System.Windows.Forms.Label();

            this.gbView = new System.Windows.Forms.GroupBox();
            this.lbWords = new System.Windows.Forms.ListBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();

            this.gbManage = new System.Windows.Forms.GroupBox();
            this.lblWord = new System.Windows.Forms.Label();
            this.tbWord = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();

            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.lblCount = new System.Windows.Forms.Label();
            this.nudCount = new System.Windows.Forms.NumericUpDown();
            this.rbConsonants = new System.Windows.Forms.RadioButton();
            this.rbVowels = new System.Windows.Forms.RadioButton();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSaveResults = new System.Windows.Forms.Button();
            this.lblResultCount = new System.Windows.Forms.Label();

            this.gbResults = new System.Windows.Forms.GroupBox();
            this.lbResults = new System.Windows.Forms.ListBox();

            this.gbFuzzy = new System.Windows.Forms.GroupBox();
            this.tbFuzzy = new System.Windows.Forms.TextBox();
            this.btnFuzzySearch = new System.Windows.Forms.Button();

            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();

            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();

            // Группа выбора словаря
            this.gbDictionary.SuspendLayout();
            this.gbView.SuspendLayout();
            this.gbManage.SuspendLayout();
            this.gbSearch.SuspendLayout();
            this.gbResults.SuspendLayout();
            this.gbFuzzy.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();

            // 
            // gbDictionary
            // 
            this.gbDictionary.Controls.Add(this.btnSelectDict);
            this.gbDictionary.Controls.Add(this.lblDictPath);
            this.gbDictionary.Location = new System.Drawing.Point(10, 10);
            this.gbDictionary.Name = "gbDictionary";
            this.gbDictionary.Size = new System.Drawing.Size(860, 60);
            this.gbDictionary.TabIndex = 0;
            this.gbDictionary.TabStop = false;
            this.gbDictionary.Text = "Выбор словаря";

            // 
            // btnSelectDict
            // 
            this.btnSelectDict.Location = new System.Drawing.Point(10, 20);
            this.btnSelectDict.Name = "btnSelectDict";
            this.btnSelectDict.Size = new System.Drawing.Size(120, 30);
            this.btnSelectDict.TabIndex = 1;
            this.btnSelectDict.Text = "Выбрать словарь";
            this.btnSelectDict.UseVisualStyleBackColor = true;
            this.btnSelectDict.Click += new System.EventHandler(this.BtnSelectDict_Click);

            // 
            // lblDictPath
            // 
            this.lblDictPath.AutoEllipsis = true;
            this.lblDictPath.Location = new System.Drawing.Point(140, 25);
            this.lblDictPath.Name = "lblDictPath";
            this.lblDictPath.Size = new System.Drawing.Size(500, 25);
            this.lblDictPath.TabIndex = 2;
            this.lblDictPath.Text = "Файл не выбран";

            // 
            // gbView
            // 
            this.gbView.Controls.Add(this.lbWords);
            this.gbView.Controls.Add(this.btnRefresh);
            this.gbView.Controls.Add(this.btnSort);
            this.gbView.Location = new System.Drawing.Point(10, 80);
            this.gbView.Name = "gbView";
            this.gbView.Size = new System.Drawing.Size(430, 200);
            this.gbView.TabIndex = 1;
            this.gbView.TabStop = false;
            this.gbView.Text = "Просмотр словаря";

            // 
            // lbWords
            // 
            this.lbWords.FormattingEnabled = true;
            this.lbWords.ItemHeight = 15;
            this.lbWords.Location = new System.Drawing.Point(10, 20);
            this.lbWords.Name = "lbWords";
            this.lbWords.Size = new System.Drawing.Size(300, 154);
            this.lbWords.TabIndex = 1;

            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(320, 20);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(90, 30);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Обновить";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);

            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(320, 60);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(90, 30);
            this.btnSort.TabIndex = 3;
            this.btnSort.Text = "Сортировать";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.BtnSort_Click);

            // 
            // gbManage
            // 
            this.gbManage.Controls.Add(this.lblWord);
            this.gbManage.Controls.Add(this.tbWord);
            this.gbManage.Controls.Add(this.btnAdd);
            this.gbManage.Controls.Add(this.btnRemove);
            this.gbManage.Controls.Add(this.btnSave);
            this.gbManage.Location = new System.Drawing.Point(450, 80);
            this.gbManage.Name = "gbManage";
            this.gbManage.Size = new System.Drawing.Size(420, 200);
            this.gbManage.TabIndex = 2;
            this.gbManage.TabStop = false;
            this.gbManage.Text = "Управление словами";

            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.Location = new System.Drawing.Point(10, 28);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(46, 15);
            this.lblWord.TabIndex = 1;
            this.lblWord.Text = "Слово:";

            // 
            // tbWord
            // 
            this.tbWord.Location = new System.Drawing.Point(70, 25);
            this.tbWord.Name = "tbWord";
            this.tbWord.Size = new System.Drawing.Size(200, 23);
            this.tbWord.TabIndex = 2;

            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(10, 60);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 30);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);

            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(110, 60);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(90, 30);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Удалить";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.BtnRemove_Click);

            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(210, 60);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 30);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Сохранить как";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);

            // 
            // gbSearch
            // 
            this.gbSearch.Controls.Add(this.lblCount);
            this.gbSearch.Controls.Add(this.nudCount);
            this.gbSearch.Controls.Add(this.rbConsonants);
            this.gbSearch.Controls.Add(this.rbVowels);
            this.gbSearch.Controls.Add(this.btnSearch);
            this.gbSearch.Controls.Add(this.btnSaveResults);
            this.gbSearch.Controls.Add(this.lblResultCount);
            this.gbSearch.Location = new System.Drawing.Point(10, 290);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(860, 120);
            this.gbSearch.TabIndex = 3;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "Поиск (Вариант 6) - По количеству согласных/гласных";

            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(10, 28);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(79, 15);
            this.lblCount.TabIndex = 1;
            this.lblCount.Text = "Количество:";

            // 
            // nudCount
            // 
            this.nudCount.Location = new System.Drawing.Point(100, 25);
            this.nudCount.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            this.nudCount.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            this.nudCount.Name = "nudCount";
            this.nudCount.Size = new System.Drawing.Size(60, 23);
            this.nudCount.TabIndex = 2;
            this.nudCount.Value = new decimal(new int[] { 2, 0, 0, 0 });

            // 
            // rbConsonants
            // 
            this.rbConsonants.AutoSize = true;
            this.rbConsonants.Checked = true;
            this.rbConsonants.Location = new System.Drawing.Point(180, 26);
            this.rbConsonants.Name = "rbConsonants";
            this.rbConsonants.Size = new System.Drawing.Size(89, 19);
            this.rbConsonants.TabIndex = 3;
            this.rbConsonants.TabStop = true;
            this.rbConsonants.Text = "Согласных";
            this.rbConsonants.UseVisualStyleBackColor = true;

            // 
            // rbVowels
            // 
            this.rbVowels.AutoSize = true;
            this.rbVowels.Location = new System.Drawing.Point(290, 26);
            this.rbVowels.Name = "rbVowels";
            this.rbVowels.Size = new System.Drawing.Size(71, 19);
            this.rbVowels.TabIndex = 4;
            this.rbVowels.Text = "Гласных";
            this.rbVowels.UseVisualStyleBackColor = true;

            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(420, 20);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 30);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Найти";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);

            // 
            // btnSaveResults
            // 
            this.btnSaveResults.Location = new System.Drawing.Point(540, 20);
            this.btnSaveResults.Name = "btnSaveResults";
            this.btnSaveResults.Size = new System.Drawing.Size(140, 30);
            this.btnSaveResults.TabIndex = 6;
            this.btnSaveResults.Text = "Сохранить результаты";
            this.btnSaveResults.UseVisualStyleBackColor = true;
            this.btnSaveResults.Click += new System.EventHandler(this.BtnSaveResults_Click);

            // 
            // lblResultCount
            // 
            this.lblResultCount.AutoSize = true;
            this.lblResultCount.Location = new System.Drawing.Point(700, 28);
            this.lblResultCount.Name = "lblResultCount";
            this.lblResultCount.Size = new System.Drawing.Size(72, 15);
            this.lblResultCount.TabIndex = 7;
            this.lblResultCount.Text = "Найдено: 0";

            // 
            // gbResults
            // 
            this.gbResults.Controls.Add(this.lbResults);
            this.gbResults.Location = new System.Drawing.Point(10, 420);
            this.gbResults.Name = "gbResults";
            this.gbResults.Size = new System.Drawing.Size(860, 180);
            this.gbResults.TabIndex = 4;
            this.gbResults.TabStop = false;
            this.gbResults.Text = "Результаты поиска";

            // 
            // lbResults
            // 
            this.lbResults.FormattingEnabled = true;
            this.lbResults.ItemHeight = 15;
            this.lbResults.Location = new System.Drawing.Point(10, 20);
            this.lbResults.Name = "lbResults";
            this.lbResults.Size = new System.Drawing.Size(840, 154);
            this.lbResults.TabIndex = 1;

            // 
            // gbFuzzy
            // 
            this.gbFuzzy.Controls.Add(this.tbFuzzy);
            this.gbFuzzy.Controls.Add(this.btnFuzzySearch);
            this.gbFuzzy.Location = new System.Drawing.Point(10, 610);
            this.gbFuzzy.Name = "gbFuzzy";
            this.gbFuzzy.Size = new System.Drawing.Size(860, 60);
            this.gbFuzzy.TabIndex = 5;
            this.gbFuzzy.TabStop = false;
            this.gbFuzzy.Text = "Нечёткий поиск (Левенштейн)";

            // 
            // tbFuzzy
            // 
            this.tbFuzzy.Location = new System.Drawing.Point(10, 25);
            this.tbFuzzy.Name = "tbFuzzy";
            this.tbFuzzy.Size = new System.Drawing.Size(200, 23);
            this.tbFuzzy.TabIndex = 1;

            // 
            // btnFuzzySearch
            // 
            this.btnFuzzySearch.Location = new System.Drawing.Point(220, 20);
            this.btnFuzzySearch.Name = "btnFuzzySearch";
            this.btnFuzzySearch.Size = new System.Drawing.Size(120, 30);
            this.btnFuzzySearch.TabIndex = 2;
            this.btnFuzzySearch.Text = "Нечёткий поиск";
            this.btnFuzzySearch.UseVisualStyleBackColor = true;
            this.btnFuzzySearch.Click += new System.EventHandler(this.BtnFuzzySearch_Click);

            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 680);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(900, 22);
            this.statusStrip.TabIndex = 6;
            this.statusStrip.Text = "statusStrip";

            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(44, 17);
            this.statusLabel.Text = "Готов";

            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Текстовые файлы|*.txt|Все файлы|*.*";
            this.openFileDialog.Title = "Выберите файл словаря";

            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Текстовые файлы|*.txt";
            this.saveFileDialog.Title = "Сохранить файл";

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 702);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.gbFuzzy);
            this.Controls.Add(this.gbResults);
            this.Controls.Add(this.gbSearch);
            this.Controls.Add(this.gbManage);
            this.Controls.Add(this.gbView);
            this.Controls.Add(this.gbDictionary);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Работа со словарём - Вариант 6";
            this.gbDictionary.ResumeLayout(false);
            this.gbView.ResumeLayout(false);
            this.gbManage.ResumeLayout(false);
            this.gbManage.PerformLayout();
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            this.gbResults.ResumeLayout(false);
            this.gbFuzzy.ResumeLayout(false);
            this.gbFuzzy.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        // Объявления элементов управления
        private System.Windows.Forms.GroupBox gbDictionary;
        private System.Windows.Forms.Button btnSelectDict;
        private System.Windows.Forms.Label lblDictPath;

        private System.Windows.Forms.GroupBox gbView;
        private System.Windows.Forms.ListBox lbWords;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSort;

        private System.Windows.Forms.GroupBox gbManage;
        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.TextBox tbWord;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnSave;

        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.NumericUpDown nudCount;
        private System.Windows.Forms.RadioButton rbConsonants;
        private System.Windows.Forms.RadioButton rbVowels;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnSaveResults;
        private System.Windows.Forms.Label lblResultCount;

        private System.Windows.Forms.GroupBox gbResults;
        private System.Windows.Forms.ListBox lbResults;

        private System.Windows.Forms.GroupBox gbFuzzy;
        private System.Windows.Forms.TextBox tbFuzzy;
        private System.Windows.Forms.Button btnFuzzySearch;

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}