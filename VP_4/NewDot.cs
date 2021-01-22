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
    public partial class NewDot : Form
    {
        public NewDot()
        {
            InitializeComponent();
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {

        }

        private void x_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && !(number == 8))
            {
                e.Handled = true;
            }
        }

        private void y_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && !(number == 8))
            {
                e.Handled = true;
            }
        }

        private void r1_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && !(number == '.') && !(number == 8))
            {
                e.Handled = true;
            }
        }

        private void r2_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && !(number == '.') && !(number == 8))
            {
                e.Handled = true;
            }
        }
    }
}
