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

namespace _6._1._44
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {
            int c = 0;
            double E = double.Parse(InputE.Text);
            double x = double.Parse(InputX.Text);
            int n = int.Parse(InputN.Text);
            Calc calculator = new Calc(x);
            string answer = "Точная сумма: " + calculator.CalculateFunctionExactly() + Environment.NewLine;
            answer += "Сумма n слагаемых: " + calculator.CalculateFunctionApproximately(n, 0, out c) + Environment.NewLine;
            answer += "Сумма n слагаемых: " + calculator.CalculateFunctionApproximately(n, E, out c) + ", слагаемых, больших E: " + c + Environment.NewLine;
            answer += "Сумма n слагаемых: " + calculator.CalculateFunctionApproximately(n, E / 10, out c) + ", слагаемых, больших E/10: " + c + Environment.NewLine;
            result.Text = answer;
        }
    }
}
