using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task3
{
    public partial class Form1 : Form
    {

        private int x, y;
        private int width, height;
        private int dx;
        private int dWidth;
        private Color shapeColor;

        private const int BaseSize = 50;
        private const int MaxStretch = 150;

        


        private bool isRunning = true;

        

        public Form1()
        {
            InitializeComponent();

            width = BaseSize;
            height = BaseSize;
            x = (this.ClientSize.Width - width) / 2;
            y = (this.ClientSize.Height - height) / 2;
            dx = 5;
            dWidth = 1;
            shapeColor = Color.Red;

            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
            this.KeyPreview = true;

            this.Paint += Form1_Paint;
            this.KeyDown += Form1_KeyDown;
            this.Resize += Form1_Resize;
            this.timerAnimation.Tick += timerAnimation_Tick;
            this.btnSettings.Click += btnSettings_Click;
            this.button1.Click += button1_Click; 

            timerAnimation.Start();
            UpdateButtonText();
        }
        private void timerAnimation_Tick(object sender, EventArgs e)
        {
            if (!isRunning) return;

            x += dx;
            if (x + width >= this.ClientSize.Width || x <= 0)
            {
                dx = -dx;
            }

            width += dWidth;
            if (width >= MaxStretch)
            {
                dWidth = -dWidth;
            }
            else if (width <= BaseSize)
            {
                dWidth = -dWidth;
                width = BaseSize;
            }

            this.Invalidate();
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            using (SolidBrush brush = new SolidBrush(shapeColor))
            {
                e.Graphics.FillEllipse(brush, x, y, width, height);
            }
            using (Pen pen = new Pen(Color.Black, 2))
            {
                e.Graphics.DrawEllipse(pen, x, y, width, height);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            isRunning = !isRunning;

            if (isRunning)
            {
                timerAnimation.Start();
            }
            else
            {
                timerAnimation.Stop();
            }

            UpdateButtonText();
        }
        private void UpdateButtonText()
        {
            if (isRunning)
            {
                button1.Text = "Стоп";
                button1.ForeColor = Color.Red;
                button1.BackColor = SystemColors.Control;
            }
            else
            {
                button1.Text = "Старт";
                button1.ForeColor = Color.ForestGreen;
                button1.BackColor = Color.LightGreen;
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Form2 settingsForm = new Form2();
            settingsForm.InitialColor = shapeColor;
            settingsForm.InitialInterval = timerAnimation.Interval;

            if (settingsForm.ShowDialog() == DialogResult.OK)
            {
                shapeColor = settingsForm.SelectedColor;
                timerAnimation.Interval = settingsForm.SelectedInterval;

                this.Invalidate();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            this.Close();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (x + width > this.ClientSize.Width)
                x = this.ClientSize.Width - width;
            if (y + height > this.ClientSize.Height)
                y = this.ClientSize.Height - height;
        }

    }
}
