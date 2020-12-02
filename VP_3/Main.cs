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
    public partial class Main : Form
    {
        public class Matrix
        {
            public double[,] items;

            private int rows;
            private int cols;

            private double A;
            private double B;
            private double C;

            private double P;

            public int GetRows() { return rows; }
            public int GetCols() { return cols; }
            public double GetP() { return P; }
            public double GetA() { return A; }
            public double GetB() { return B; }
            public double GetC() { return C; }

            public void SetSize(int rows, int cols)
            {
                this.items = null;
                this.rows = rows;
                this.cols = cols;
                this.items = new double[rows, cols];
            }

            public void SetRandom(double leftBorder, double rightBorder)
            {
                Random random = new Random();
                A = leftBorder + random.NextDouble() * (rightBorder - leftBorder);
                B = leftBorder + random.NextDouble() * (rightBorder - leftBorder);
                C = leftBorder + random.NextDouble() * (rightBorder - leftBorder);
            }

            public void CalcItemsAndP()
            {
                int itemsNumber = rows * cols;
                P = 1;
                for (int i = 0; i < rows; i++)
                    for (int j = 0; j < cols; j++)
                    {
                        items[i, j] = A * (i + 1) + B * Math.Exp(C * (j + 1));
                        P *= Math.Pow(items[i, j], 1.0 / itemsNumber);
                    }
            }
        }

        public int rows;
        public int cols;
        public double leftBorder;
        public double rightBorder;
       

        public Main()
        {
            InitializeComponent();
        }

        private void closeFormButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Exit",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) Close();
        }

        private void createMatrixButton_Click(object sender, EventArgs e)
        {
            // создаём матрицу
            Matrix matrix = new Matrix();

            // создаём и вызываем модальное окно
            CreateNewMatrixForm EnterNewMatrix = new CreateNewMatrixForm();
            EnterNewMatrix.Owner = this;
            EnterNewMatrix.ShowDialog();

            // если окно вернуло ОК (значит, со значениями всё хорошо)
            if (EnterNewMatrix.DialogResult == DialogResult.OK)
            {
                // передаём в матрицу параметры
                matrix.SetSize(rows, cols);
                matrix.SetRandom(leftBorder, rightBorder);
                // вычисляем элементы матрицы и параметр по варианту
                matrix.CalcItemsAndP();

                // устанавливаем параметры грида
                dataGridView1.RowCount = matrix.GetRows();
                dataGridView1.ColumnCount = matrix.GetCols();

                // заполняем грид
                for (int i = 0; i < matrix.GetRows(); i++)
                    for (int j = 0; j < matrix.GetCols(); j++)
                        dataGridView1.Rows[i].Cells[j].Value = matrix.items[i, j];

                // заполняем лейблы с параметрами
                pLabel.Text = "P = " + matrix.GetP().ToString();
                pLabel.Visible = true;

                aLabel.Text = "A = " + matrix.GetA().ToString();
                aLabel.Visible = true;
                bLabel.Text = "B = " + matrix.GetB().ToString();
                bLabel.Visible = true;
                cLabel.Text = "C = " + matrix.GetC().ToString();
                cLabel.Visible = true;

                // индексы максимальных элементов в столбцах
                int[] indexOfMaxInColumns = new int[matrix.GetCols()];
                if (matrix.GetP() > 5.17)
                {
                    // промежуточная переменная максимума в столбце
                    // переменная для минимума матрицы
                    double maxValue, minValue = (Math.Pow(2, 31));
                    for (int j = 0; j < matrix.GetCols(); j++)
                    {
                        maxValue = -(Math.Pow(2, 31)); // здесь должнo быть FLT_MIN
                        for (int i = 0; i < matrix.GetRows(); i++)
                        {
                            if (matrix.items[i, j] > maxValue)
                            {
                                maxValue = matrix.items[i, j];
                                indexOfMaxInColumns[j] = i;
                            }
                            if (matrix.items[i, j] < minValue) minValue = matrix.items[i, j];
                        }
                    }

                    minLabel.Visible = true;
                    minLabel.Text = "Min = " + minValue.ToString();
                    for (int j = 0; j < matrix.GetCols(); j++)
                        matrix.items[indexOfMaxInColumns[j], j] = minValue;

                    // устанавливаем параметры грида
                    // это должно быть обёрнуто в функцию
                    dataGridView2.RowCount = matrix.GetRows();
                    dataGridView2.ColumnCount = matrix.GetCols();

                    // заполняем грид
                    // и это тоже
                    for (int i = 0; i < matrix.GetRows(); i++)
                        for (int j = 0; j < matrix.GetCols(); j++)
                            dataGridView2.Rows[i].Cells[j].Value = matrix.items[i, j];
                    dataGridView2.Visible = true;
                }
            }
        }
    }
}
