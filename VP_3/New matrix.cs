using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP_3
{
    public partial class CreateNewMatrixForm : Form
    {
        public CreateNewMatrixForm()
        {
            InitializeComponent();
        }

        private void createNewMatrixForm_Load(object sender, EventArgs e)
        {
            
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (rowsTextBox.Text == "" || colsTextBox.Text == "" || randLeftBorderTextBox.Text == "" || randRightBorderTextBox.Text == "")
            {
                MessageBox.Show("Fill every textbox!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                okButton.DialogResult = DialogResult.None;
            }

            else
            {
                Main main = this.Owner as Main;
                main.rows = Convert.ToInt32(this.rowsTextBox.Text);
                main.cols = Convert.ToInt32(this.colsTextBox.Text);

                main.leftBorder = Convert.ToInt32(this.randLeftBorderTextBox.Text);
                main.rightBorder = Convert.ToInt32(this.randRightBorderTextBox.Text);

                okButton.DialogResult = DialogResult.OK;
            }
        }

        private void rowsTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && !(number == 8))
            {
                e.Handled = true;
            }
        }

        private void colsTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && !(number == 8))
            {
                e.Handled = true;
            }
        }

        private void randLeftBorderTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && !(number == '.') && !(number == 8))
            {
                e.Handled = true;
            }
        }

        private void randRightBorderTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && !(number == '.') && !(number == 8))
            {
                e.Handled = true;
            }
        }
    }
}

