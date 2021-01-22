using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using System.Windows.Forms;

namespace lab4
{
    public partial class Form1 : Form
    {
        Vector A, B;

        private int aLen, bLen;
        private double leftRandA, rightRandA, leftRandB, rightRandB;

        int dotX, dotY;
        double R1, R2;

        int task1_inRing = 0;
        int task2_imax = 0;
        int task3_inArea = 0;


        public Form1() {
            InitializeComponent();
        }

        private void menu_source_fromFile_Click(object sender, EventArgs e) {
            OpenFileDialog open_file_dialog = new OpenFileDialog();
            open_file_dialog.Title = "Выберите файл для массива А";
            open_file_dialog.CheckFileExists = true;
            if (open_file_dialog.ShowDialog(this) == DialogResult.OK) {
                string path = open_file_dialog.FileName;

                try {
                    A = new Vector(path);

                    open_file_dialog.Title = "Выберите файл для массива B";
                    if (open_file_dialog.ShowDialog(this) == DialogResult.OK) {
                        path = open_file_dialog.FileName;

                        B = new Vector(path);

                        A.FillDataGrid(aVector_dataGridView);
                        B.FillDataGrid(bVector_dataGridView);

                        menu_handling.Enabled = true;
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message, "Ошибка при чтении из файла", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void menu_source_random_Click(object sender, EventArgs e) {
            A = new Vector(aLen, leftRandA, rightRandA);
            B = new Vector(bLen, leftRandB, rightRandB);

            A.FillDataGrid(aVector_dataGridView);
            B.FillDataGrid(bVector_dataGridView);

            menu_handling.Enabled = true;
        }

        private void menu_handling_task1_Click(object sender, EventArgs e) 
        {
            NewDot EnterDot = new NewDot();
            //EnterDot.Owner = this;
            EnterDot.ShowDialog(this);
            if (EnterDot.DialogResult == DialogResult.OK)
            {
                dotX = Convert.ToInt32(EnterDot.x_textbox.Text);
                dotY = Convert.ToInt32(EnterDot.y_textbox.Text);

                R1 = Convert.ToDouble(EnterDot.r1_textbox.Text);
                R2 = Convert.ToDouble(EnterDot.r2_textbox.Text);

                for (int i = 0; i < A.length; i++) 
                {
                    double distance = Math.Sqrt(Math.Pow((double)(A[i] - dotX), (double)(2)) + Math.Pow((double)(B[i] - dotY), (double)(2)));
                    if (distance > R2 && distance < R1) ++task1_inRing;
                }

                answer_label.Text = "Точек: " + Convert.ToString(task1_inRing);
                answer_label.Visible = true;
            }
        }

        private void menu_handling_task2_Click(object sender, EventArgs e) 
        {
            double maxP = -1000, maxF = -1000;
            for (int i = 0; i < A.length; i++)
            {
                double P = Math.Sqrt(Math.Pow((double)(A[i]), (double)(2)) + Math.Pow((double)(B[i]), (double)(2)));
                double F = Math.Atan(B[i] / A[i]);
                if (P > maxP && F > maxF)
                {
                    maxP = P;
                    maxF = F;
                    task2_imax = i;
                }
            }
            answer_label.Text = "Точка №" + Convert.ToString(task2_imax) + ": " + "(" + Convert.ToString(A[task2_imax]) +
                    ", " + Convert.ToString(B[task2_imax]) + ")";
            answer_label.Visible = true;
        }

        private void menu_handling_task3_Click(object sender, EventArgs e) {
            for (int i = 0; i < B.length; i++)
                if (A[i] > 0 && A[i] < Math.PI / 2 &&
                    B[i] > 0 && B[i] < Math.Sin(A[i]))

                    ++task3_inArea;

            answer_label.Text = "Точек: " + Convert.ToString(task3_inArea);
            answer_label.Visible = true;
        }

        private void menu_save_saveHow_Click(object sender, EventArgs e) {
            SaveFileDialog save_file_dialog = new SaveFileDialog();
            save_file_dialog.Title = "Сохранить данные";
            save_file_dialog.DefaultExt = ".txt";
            if (save_file_dialog.ShowDialog(this) == DialogResult.OK) {
                string path = save_file_dialog.FileName;
                if (!File.Exists(path)) {
                    FileStream fs = File.Create(path);
                    fs.Close();
                }

                string result = 
                    "Массив А:\n" +
                    A +
                    "\nМассив B:\n" +
                    B +
                    "\n\nЗадание 1:\n" + task1_inRing +
                    "\n\nЗадание 2:\n" + task2_imax +
                    "\n\nЗадание 3:\n" + task3_inArea;

                using (StreamWriter sw = new StreamWriter(path, false)) {
                    sw.Write(result);
                }
            }
        }

        private void menu_params_Click(object sender, EventArgs e) {
            ParamsForm EnterParams = new ParamsForm();
            EnterParams.Owner = this;
            if (EnterParams.ShowDialog(this) == DialogResult.OK) {
                aLen = Convert.ToInt32(EnterParams.aLen_textbox.Text);
                bLen = Convert.ToInt32(EnterParams.bLen_textbox.Text);
                leftRandA = Convert.ToDouble(EnterParams.leftRandA_textbox.Text);
                rightRandA = Convert.ToDouble(EnterParams.rightRandA_textbox.Text);
                leftRandB = Convert.ToDouble(EnterParams.leftRandB_textbox.Text);
                rightRandB = Convert.ToDouble(EnterParams.rightRandB_textbox.Text);

                menu_source_random.Enabled = true;
            }
        }

        private void menu_exit_Click(object sender, EventArgs e) {
            DialogResult res = MessageBox.Show("Вы уверены, что хотите выйти из программы?", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
                this.Close();
        }
    }
}
