using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyLibr;
using Utils;


namespace _9._1._13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataGridViewUtils.InitGridForArr(dataGridView1, 40, false, true, true, true, true);
            DataGridViewUtils.InitGridForArr(dataGridView2, 40, false, true, true, true, true);
        }

        private void button_fill(object sender, EventArgs e)
        {
            int[,] arr = ArrayUtils.CreateRandomArray2(dataGridView1.RowCount, dataGridView1.ColumnCount, 30);
            DataGridViewUtils.ArrayToGrid(dataGridView1, arr);

        }

        private void button_move_right(object sender, EventArgs e)
        {
            if (Input.Text.Trim().Length == 0)
            {
                Result("Ничего не введено!");
                return;
            }
            int n;
            try
            {
                n = int.Parse(Input.Text);
            }
            catch
            {
                Result("Необходимо целое число!");
                return;
            }
            int[,] arr = DataGridViewUtils.GridToArray2<int>(dataGridView1);
            ArrayUtility asd = new ArrayUtility(arr, n);
            DataGridViewUtils.ArrayToGrid(dataGridView2, asd.ArrayMoveRight());
        }

        private void button_move_down(object sender, EventArgs e)
        {
            if (Input.Text.Trim().Length == 0)
            {
                Result("Ничего не введено!");
                return;
            }
            int n;
            try
            {
                n = int.Parse(Input.Text);
            }
            catch
            {
                Result("Необходимо целое число!");
                return;
            }
            int[,] arr = DataGridViewUtils.GridToArray2<int>(dataGridView1);
            ArrayUtility asd = new ArrayUtility(arr, n);
            DataGridViewUtils.ArrayToGrid(dataGridView2, asd.ArrayMoveDown());
        }

        private void Result(string text)
        {
            Input.Show();
            Input.Text = text;
        }
        //13. Осуществить циклический сдвиг столбцов или строк(указывается отдельно) двумерного массива на n позиций.
    }
}