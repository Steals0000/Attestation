using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;

namespace _7._1._13
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void check_Click(object sender, EventArgs e)
        {
            double Aver = 0;
            if (input.Text.Trim().Length == 0)
            {
                Result("Массив не введен!");
                return;
            }
            int[] array = { };
            try
            {
                array = new StringProcessing().StrToArray<int>(input.Text);
            }
            catch
            {
                Result("На вход принимаются только целые числа!");
                return;
            }
            WorkWithArrays Array = new WorkWithArrays(array);
            string answer = "Количество элементов: " + Array.Calculation(out Aver) + "; Среднее арифметическое: " + Aver; 
            Result(answer);
        }

        private void Result(string text)
        {
            result.Show();
            result.Text = text;
        }
        //44. Вводится массив целых чисел.Найти количество элементов массива, которые максимально близки к среднему арифметическому для всех элементов массива.
        //    Например, для массива { 1, 4, 2, 5, 8, 4, 1, 3 } ответ равен 3 
        //    (среднее арифметическое – 3.5, максимально близкие элементы со значением 3 и 4 – оба отличаются на 0.5).
    }
}

