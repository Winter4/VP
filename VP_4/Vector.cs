using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace lab4
{
    class Vector {
        private double[] items;
        public int length = 0;

        public Vector(string path) {
            string contents;

            using (StreamReader sr = new StreamReader(path)) {
                contents = sr.ReadToEnd();
            }

            string[] subs = contents.Split(' ');
            length = subs.Length;
            items = new double[length];

            for (int i = 0; i < length; i++)
                items[i] = Int32.Parse(subs[i]);
        }

        private double GetRandomNumber(Random random, double minimum, double maximum)
        {
            return random.NextDouble() * (maximum - minimum) + minimum;
        }

        public Vector(int new_length, double rand_from, double rand_to) {
            Random random = new Random((int)DateTime.Now.Ticks);
            length = new_length;
            items = new double[length];

            for (int i = 0; i < length; i++)
                items[i] = GetRandomNumber(random, rand_from, rand_to);
        }

        public Vector(int new_length) {
            length = new_length;
            items = new double[length];

            for (int i = 0; i < length; i++)
                items[i] = 0;
        }

        public int CountElements(double element) {
            int counter = 0;

            for (int i = 0; i < length; i++)
                if (items[i] == element)
                    counter++;

            return counter;
        }

        public int FindSequence(Vector sequence) {
            int position = -1;

            for (int i = 0; i < length; i++) {
                if (i + sequence.length > length)
                    break;

                bool flag = true;

                for (int j = 0; j < sequence.length; j++) {
                    if (sequence[j] != items[i + j]) {
                        flag = false;
                        break;
                    }
                }

                if (flag) position = i;
            }

            return position;
        }

        public void FillDataGrid(DataGridView datagrid) {
            datagrid.Rows.Clear();
            datagrid.Columns.Clear();

            datagrid.ColumnCount = length;

            DataGridViewRow row = new DataGridViewRow();

            for (int columnIndex = 0; columnIndex < length; ++columnIndex) {
                row.Cells.Add(new DataGridViewTextBoxCell() {
                    Value = Math.Round((decimal)items[columnIndex], 3)
                });
            }

            datagrid.Rows.Add(row);
        }

        public override string ToString() {
            string result = "";
            for (int i = 0; i < length; i++) {
                result += "" + items[i];
                if (i != length - 1) 
                    result += " ";
            }
            return result;
        }

        public double this[int i] {
            get { return items[i]; }
            set { items[i] = value; }
        }
    }
}
