using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP_2
{
    public partial class Form1 : Form
    {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_DoubleClick(object sender, EventArgs e) {
            MessageBox.Show("Karpovich V. D., Lb 2", "Info", MessageBoxButtons.OK ,MessageBoxIcon.Asterisk);
        }

        private void button1_Click(object sender, EventArgs e) {
            DialogResult result = MessageBox.Show("Are you sure?", "Exit", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) Close();
        }

        private void addTextButton_Click(object sender, EventArgs e) {
            textBoxAdd.Text += "Some text";
            textBoxAdd.Select(textBoxAdd.TextLength - 9, 9);
            textBoxAdd.Focus();
        }

        private void deleteSelectedTextButton_Click(object sender, EventArgs e) {
         //   int selectionStart = textBoxDelete.SelectionStart;
         //   int selectionEnd = textBoxDelete.SelectionLength;
            textBoxDelete.Text = textBoxDelete.Text.Remove(textBoxDelete.SelectionStart, textBoxDelete.SelectionLength);
        }

        private void colorChooseList_SelectedIndexChanged(object sender, EventArgs e) {
            switch (colorChooseList.SelectedIndex + 1) {
                case 1:
                    textBoxAdd.ForeColor = Color.Red;
                    this.Text = "Karpovich V. Lab 2 | Red";
                    break;
                case 2:
                    textBoxAdd.ForeColor = Color.Green;
                    this.Text = "Karpovich V. Lab 2 | Green";
                    break;
                case 3:
                    this.Text = "Karpovich V. Lab 2 | Blue";
                    textBoxAdd.ForeColor = Color.Blue;
                    break;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void changeRadioButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("On");
            textBoxAdd.Enabled = true;
            textBoxDelete.Enabled = true;
        }

        private void notchangeRadioButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Off");
            textBoxAdd.Enabled = false;
            textBoxDelete.Enabled = false;
        }
    }
}

// почему кнопка не работает
// enabled подходит или нет ?
// комбобокс сломался
