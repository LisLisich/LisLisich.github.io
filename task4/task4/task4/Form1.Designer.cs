namespace task4
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblVirusName = new System.Windows.Forms.Label();
            this.txtVirusName = new System.Windows.Forms.TextBox();
            this.lblAttackCount = new System.Windows.Forms.Label();
            this.nudAttackCount = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.colVirusName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAttackCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblChartInfo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.chartVirus = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.statusStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAbout = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.nudAttackCount)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.statusStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartVirus)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblVirusName
            // 
            this.lblVirusName.AutoSize = true;
            this.lblVirusName.Location = new System.Drawing.Point(6, 12);
            this.lblVirusName.Name = "lblVirusName";
            this.lblVirusName.Size = new System.Drawing.Size(98, 13);
            this.lblVirusName.TabIndex = 0;
            this.lblVirusName.Text = "Название вируса:";
            // 
            // txtVirusName
            // 
            this.txtVirusName.Location = new System.Drawing.Point(110, 9);
            this.txtVirusName.MaxLength = 50;
            this.txtVirusName.Name = "txtVirusName";
            this.txtVirusName.Size = new System.Drawing.Size(200, 20);
            this.txtVirusName.TabIndex = 1;
            // 
            // lblAttackCount
            // 
            this.lblAttackCount.AutoSize = true;
            this.lblAttackCount.Location = new System.Drawing.Point(6, 45);
            this.lblAttackCount.Name = "lblAttackCount";
            this.lblAttackCount.Size = new System.Drawing.Size(95, 13);
            this.lblAttackCount.TabIndex = 2;
            this.lblAttackCount.Text = "Количество атак:";
            // 
            // nudAttackCount
            // 
            this.nudAttackCount.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudAttackCount.Location = new System.Drawing.Point(110, 45);
            this.nudAttackCount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudAttackCount.Name = "nudAttackCount";
            this.nudAttackCount.Size = new System.Drawing.Size(200, 20);
            this.nudAttackCount.TabIndex = 3;
            this.nudAttackCount.ThousandsSeparator = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(6, 82);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(148, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(162, 82);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(148, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Очистить поля";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(621, 371);
            this.tabControl1.TabIndex = 6;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblVirusName);
            this.tabPage1.Controls.Add(this.btnClear);
            this.tabPage1.Controls.Add(this.txtVirusName);
            this.tabPage1.Controls.Add(this.btnAdd);
            this.tabPage1.Controls.Add(this.lblAttackCount);
            this.tabPage1.Controls.Add(this.nudAttackCount);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(613, 345);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ввод данных";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblTotal);
            this.tabPage2.Controls.Add(this.btnDelete);
            this.tabPage2.Controls.Add(this.btnClearAll);
            this.tabPage2.Controls.Add(this.dgvData);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(613, 345);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Таблица данных";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(6, 321);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(75, 13);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "Всего атак: 0";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(377, 316);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(108, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Удалить строку";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(491, 316);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(108, 23);
            this.btnClearAll.TabIndex = 1;
            this.btnClearAll.Text = "Очистить всё";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colVirusName,
            this.colAttackCount});
            this.dgvData.Location = new System.Drawing.Point(6, 6);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(601, 292);
            this.dgvData.TabIndex = 0;
            // 
            // colVirusName
            // 
            this.colVirusName.HeaderText = "Название вируса";
            this.colVirusName.Name = "colVirusName";
            this.colVirusName.ReadOnly = true;
            // 
            // colAttackCount
            // 
            this.colAttackCount.HeaderText = "Количество атак";
            this.colAttackCount.Name = "colAttackCount";
            this.colAttackCount.ReadOnly = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.statusStrip2);
            this.tabPage3.Controls.Add(this.lblChartInfo);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.chartVirus);
            this.tabPage3.Controls.Add(this.statusStrip1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(613, 345);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Диаграмма";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // statusStrip2
            // 
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip2.Location = new System.Drawing.Point(3, 296);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(607, 22);
            this.statusStrip2.TabIndex = 4;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(592, 17);
            this.statusLabel.Spring = true;
            this.statusLabel.Text = "Готов";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblChartInfo
            // 
            this.lblChartInfo.AutoSize = true;
            this.lblChartInfo.Location = new System.Drawing.Point(8, 325);
            this.lblChartInfo.Name = "lblChartInfo";
            this.lblChartInfo.Size = new System.Drawing.Size(0, 13);
            this.lblChartInfo.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(472, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Обновить диаграмму";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chartVirus
            // 
            this.chartVirus.BackColor = System.Drawing.Color.WhiteSmoke;
            this.chartVirus.BackSecondaryColor = System.Drawing.Color.White;
            this.chartVirus.BorderlineColor = System.Drawing.Color.Gray;
            this.chartVirus.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.Area3DStyle.Inclination = 15;
            chartArea1.Area3DStyle.Rotation = 10;
            chartArea1.AxisX.Title = "Тип вируса";
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Angle = -45;
            chartArea1.AxisY.Title = "Количество атак";
            chartArea1.BackColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            this.chartVirus.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartVirus.Legends.Add(legend1);
            this.chartVirus.Location = new System.Drawing.Point(6, 6);
            this.chartVirus.Name = "chartVirus";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Color = System.Drawing.Color.SteelBlue;
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartVirus.Series.Add(series1);
            this.chartVirus.Size = new System.Drawing.Size(600, 280);
            this.chartVirus.TabIndex = 0;
            this.chartVirus.Text = "chart1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuHelp});
            this.statusStrip1.Location = new System.Drawing.Point(3, 318);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(607, 24);
            this.statusStrip1.TabIndex = 2;
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSave,
            this.menuLoad,
            this.toolStripSeparator1,
            this.menuExit});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(48, 20);
            this.menuFile.Text = "Файл";
            // 
            // menuSave
            // 
            this.menuSave.Name = "menuSave";
            this.menuSave.Size = new System.Drawing.Size(163, 22);
            this.menuSave.Text = "Сохранить как...";
            this.menuSave.Click += new System.EventHandler(this.menuSave_Click);
            // 
            // menuLoad
            // 
            this.menuLoad.Name = "menuLoad";
            this.menuLoad.Size = new System.Drawing.Size(163, 22);
            this.menuLoad.Text = "Загрузить...";
            this.menuLoad.Click += new System.EventHandler(this.menuLoad_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(160, 6);
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(163, 22);
            this.menuExit.Text = "Выход";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // menuHelp
            // 
            this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAbout});
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(65, 20);
            this.menuHelp.Text = "Справка";
            // 
            // menuAbout
            // 
            this.menuAbout.Name = "menuAbout";
            this.menuAbout.Size = new System.Drawing.Size(149, 22);
            this.menuAbout.Text = "О программе";
            this.menuAbout.Click += new System.EventHandler(this.menuAbout_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 395);
            this.Controls.Add(this.tabControl1);
            this.MainMenuStrip = this.statusStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.nudAttackCount)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartVirus)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblVirusName;
        private System.Windows.Forms.TextBox txtVirusName;
        private System.Windows.Forms.Label lblAttackCount;
        private System.Windows.Forms.NumericUpDown nudAttackCount;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVirusName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAttackCount;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartVirus;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblChartInfo;
        private System.Windows.Forms.MenuStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuSave;
        private System.Windows.Forms.ToolStripMenuItem menuLoad;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStripMenuItem menuAbout;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
    }
}

