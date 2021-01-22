using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4
{
    public partial class ParamsForm : Form
    {
        public ParamsForm()
        {
            InitializeComponent();
        }
    

        private bool ValuesCheck()
        {

            if (Convert.ToInt32(aLen_textbox.Text) < 0 || aLen_textbox.Text == "")
            {
                MessageBox.Show("Ошибка в длине А", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (Convert.ToInt32(bLen_textbox.Text) < 0 || bLen_textbox.Text == "")
            {
                MessageBox.Show("Ошибка в длине В", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (Convert.ToInt32(bLen_textbox.Text) != Convert.ToInt32(aLen_textbox.Text))
            {
                MessageBox.Show("A не равно В", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (Convert.ToDouble(leftRandA_textbox.Text) > Convert.ToDouble(rightRandA_textbox.Text) ||
                Convert.ToDouble(leftRandB_textbox.Text) > Convert.ToDouble(rightRandB_textbox.Text)
                || leftRandA_textbox.Text == "" || rightRandA_textbox.Text == ""
                || leftRandB_textbox.Text == "" || rightRandB_textbox.Text == "")
            {
                MessageBox.Show("Неправильный рандом", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            double rand_fromA = Convert.ToDouble(leftRandA_textbox.Text);
            double rand_toA = Convert.ToDouble(rightRandA_textbox.Text);
            double rand_fromB = Convert.ToDouble(leftRandB_textbox.Text);
            double rand_toB = Convert.ToDouble(rightRandB_textbox.Text);

            return true;
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ok_btn_Click(object sender, EventArgs e)
        {
            if (ValuesCheck())
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Ошибка ввода", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private void aLen_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && !(number == 8))
            {
                e.Handled = true;
            }
        }

        private void bLen_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && !(number == 8))
            {
                e.Handled = true;
            }
        }

        private void leftRandA_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && !(number == '-') && !(number == '.') && !(number == 8))
            {
                e.Handled = true;
            }
        }

        private void rightRandA_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && !(number == '-') && !(number == '.') && !(number == 8))
            {
                e.Handled = true;
            }
        }

        private void leftRandB_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && !(number == '-') && !(number == '.') && !(number == 8))
            {
                e.Handled = true;
            }
        }

        private void rightRandB_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && !(number == '-') && !(number == '.') && !(number == 8))
            {
                e.Handled = true;
            }
        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            ValuesCheck();
        }
    }
}
