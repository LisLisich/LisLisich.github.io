using System;
using System.Windows.Forms;

namespace task6.Forms
{
    public partial class InputDialog : Form
    {
        public string Result { get; private set; }

        public InputDialog(string title, string prompt)
        {
            InitializeComponent();
            this.Text = title;
            lblPrompt.Text = prompt;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Result = txtInput.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}