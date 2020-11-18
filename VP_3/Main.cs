#include "stdlib.h"

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
            private double[,] items;
            
            private int rows;
            //public int Rows { get => this.rows; }

            private int cols;
            //public int Cols { get => this.cols; }
            

            public Matrix(int rows, int cols)
            {
                this.rows = rows;
                this.cols = cols;
                this.items = new double[rows, cols];
            }
        }

        public Main()
        {
            InitializeComponent();
        }

        public Main(int rows, int cols, float leftBorder, float rightBorder) // bord - граница рандома
        {
            Matrix matrix = new Matrix(rows, cols);
            float A, B, C;
            A = (rightBorder - leftBorder) * rand() / RAND_MAX + leftBorder;
        }

        private void closeFormButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Exit",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) Close();
        }

        private void createMatrixButton_Click(object sender, EventArgs e)
        {
            int rows, cols;
            CreateNewMatrixForm EnterNewMatrix = new CreateNewMatrixForm();
            EnterNewMatrix.Owner = this;
            EnterNewMatrix.ShowDialog();

            if (EnterNewMatrix.DialogResult == DialogResult.OK)
                rows;
        }

    }
}
