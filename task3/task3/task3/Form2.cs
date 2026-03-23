using System;
using System.Drawing;
using System.Windows.Forms;

namespace task3
{
    public partial class Form2 : Form
    {
        public Color SelectedColor { get; private set; }
        public int SelectedInterval { get; private set; }
        public Color InitialColor { get; set; }
        public int InitialInterval { get; set; }

        public Form2()
        {
            InitializeComponent();
            this.btnOK.CausesValidation = false;
            this.btnCancel.CausesValidation = false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            SelectedColor = InitialColor;
            SelectedInterval = InitialInterval;

            trackBar1.Value = InitialInterval;
            btnColor.BackColor = InitialColor;
            btnColor.Text = ""; 
            groupBox1.Text = $"Скорость: {InitialInterval} мс";
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = btnColor.BackColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                SelectedColor = colorDialog1.Color;
                btnColor.BackColor = SelectedColor;
                btnColor.Text = "";
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            SelectedInterval = trackBar1.Value;
            groupBox1.Text = $"Скорость: {trackBar1.Value} мс";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            SelectedColor = btnColor.BackColor;
            SelectedInterval = trackBar1.Value;
            this.DialogResult = DialogResult.OK;

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}