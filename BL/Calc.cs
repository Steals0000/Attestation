using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Calc
    {
        private double X;

        public Calc(double x)
        {
            X = x;
        }

        public double CalculateFunctionExactly()
        {
            return Math.Cosh(X);
        }

        public double CalculateFunctionApproximately(int n, double e, out int c)
        {
            c = 0;
            double result = 1;
            double last = 1;

            if (last > e)
                c++;

            for (int i = 1; i < n; i++)
            {
                last *= (X * X) / ((2 * i) * (2 * i - 1));

                if (Math.Abs(last) > e)
                {
                    result += last;
                    c++;
                }
            }

            return result;
        }
    }
}
