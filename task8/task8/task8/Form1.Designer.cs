namespace task8
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.менюФайлВыходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.менюНастройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.менюРезультатыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.менюСправкаОИгреToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblMoves = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.gameBoard = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.mainTableLayoutPanel.SuspendLayout();
            this.infoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStrip1.ForeColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюФайлToolStripMenuItem,
            this.менюНастройкиToolStripMenuItem,
            this.менюРезультатыToolStripMenuItem,
            this.менюСправкаОИгреToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(900, 29);
            this.menuStrip1.TabIndex = 0;
            // 
            // менюФайлToolStripMenuItem
            // 
            this.менюФайлToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.менюФайлToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.менюФайлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюФайлВыходToolStripMenuItem});
            this.менюФайлToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.менюФайлToolStripMenuItem.Name = "менюФайлToolStripMenuItem";
            this.менюФайлToolStripMenuItem.Size = new System.Drawing.Size(48, 25);
            this.менюФайлToolStripMenuItem.Text = "Файл";
            // 
            // менюФайлВыходToolStripMenuItem
            // 
            this.менюФайлВыходToolStripMenuItem.Name = "менюФайлВыходToolStripMenuItem";
            this.менюФайлВыходToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.менюФайлВыходToolStripMenuItem.Text = "Выход";
            this.менюФайлВыходToolStripMenuItem.Click += new System.EventHandler(this.менюФайлВыходToolStripMenuItem_Click);
            // 
            // менюНастройкиToolStripMenuItem
            // 
            this.менюНастройкиToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.менюНастройкиToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.менюНастройкиToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.менюНастройкиToolStripMenuItem.Name = "менюНастройкиToolStripMenuItem";
            this.менюНастройкиToolStripMenuItem.Size = new System.Drawing.Size(84, 25);
            this.менюНастройкиToolStripMenuItem.Text = "Настройки";
            this.менюНастройкиToolStripMenuItem.Click += new System.EventHandler(this.менюНастройкиToolStripMenuItem_Click);
            // 
            // менюРезультатыToolStripMenuItem
            // 
            this.менюРезультатыToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.менюРезультатыToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.менюРезультатыToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.менюРезультатыToolStripMenuItem.Name = "менюРезультатыToolStripMenuItem";
            this.менюРезультатыToolStripMenuItem.Size = new System.Drawing.Size(91, 25);
            this.менюРезультатыToolStripMenuItem.Text = "Результаты";
            this.менюРезультатыToolStripMenuItem.Click += new System.EventHandler(this.менюРезультатыToolStripMenuItem_Click);
            // 
            // менюСправкаОИгреToolStripMenuItem
            // 
            this.менюСправкаОИгреToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.менюСправкаОИгреToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.менюСправкаОИгреToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.менюСправкаОИгреToolStripMenuItem.Name = "менюСправкаОИгреToolStripMenuItem";
            this.менюСправкаОИгреToolStripMenuItem.Size = new System.Drawing.Size(64, 25);
            this.менюСправкаОИгреToolStripMenuItem.Text = "Справка";
            this.менюСправкаОИгреToolStripMenuItem.Click += new System.EventHandler(this.менюСправкаОИгреToolStripMenuItem_Click);
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.ColumnCount = 1;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayoutPanel.Controls.Add(this.infoPanel, 0, 0);
            this.mainTableLayoutPanel.Controls.Add(this.gameBoard, 0, 1);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 29);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 2;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(900, 571);
            this.mainTableLayoutPanel.TabIndex = 1;
            // 
            // infoPanel
            // 
            this.infoPanel.BackColor = System.Drawing.Color.White;
            this.infoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.infoPanel.Controls.Add(this.btnRegister);
            this.infoPanel.Controls.Add(this.lblMoves);
            this.infoPanel.Controls.Add(this.lblScore);
            this.infoPanel.Controls.Add(this.lblTimer);
            this.infoPanel.Controls.Add(this.btnStartGame);
            this.infoPanel.Controls.Add(this.txtLogin);
            this.infoPanel.Controls.Add(this.lblLogin);
            this.infoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoPanel.Location = new System.Drawing.Point(3, 3);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(894, 104);
            this.infoPanel.TabIndex = 0;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(350, 65);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(120, 30);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "Регистрация";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblMoves
            // 
            this.lblMoves.AutoSize = true;
            this.lblMoves.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblMoves.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.lblMoves.Location = new System.Drawing.Point(550, 68);
            this.lblMoves.Name = "lblMoves";
            this.lblMoves.Size = new System.Drawing.Size(56, 20);
            this.lblMoves.TabIndex = 5;
            this.lblMoves.Text = "Ходы: ";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.lblScore.Location = new System.Drawing.Point(550, 40);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(50, 20);
            this.lblScore.TabIndex = 4;
            this.lblScore.Text = "Пары:";
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTimer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.lblTimer.Location = new System.Drawing.Point(550, 12);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(56, 20);
            this.lblTimer.TabIndex = 3;
            this.lblTimer.Text = "Время:";
            // 
            // btnStartGame
            // 
            this.btnStartGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnStartGame.FlatAppearance.BorderSize = 0;
            this.btnStartGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartGame.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnStartGame.ForeColor = System.Drawing.Color.White;
            this.btnStartGame.Location = new System.Drawing.Point(200, 62);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(130, 35);
            this.btnStartGame.TabIndex = 2;
            this.btnStartGame.Text = "Начать игру";
            this.btnStartGame.UseVisualStyleBackColor = false;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // txtLogin
            // 
            this.txtLogin.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtLogin.Location = new System.Drawing.Point(200, 30);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(180, 25);
            this.txtLogin.TabIndex = 1;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblLogin.Location = new System.Drawing.Point(20, 33);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(115, 19);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Введите логин:";
            // 
            // gameBoard
            // 
            this.gameBoard.ColumnCount = 4;
            this.gameBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.gameBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.gameBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.gameBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.gameBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameBoard.Location = new System.Drawing.Point(3, 113);
            this.gameBoard.Name = "gameBoard";
            this.gameBoard.RowCount = 4;
            this.gameBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.gameBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.gameBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.gameBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.gameBoard.Size = new System.Drawing.Size(894, 455);
            this.gameBoard.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.mainTableLayoutPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "🎮 Парные картинки (Вариант 6)";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюФайлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem менюФайлВыходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem менюНастройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem менюСправкаОИгреToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.TableLayoutPanel gameBoard;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblMoves;
        private System.Windows.Forms.ToolStripMenuItem менюРезультатыToolStripMenuItem;
        private System.Windows.Forms.Button btnRegister;
    }
}