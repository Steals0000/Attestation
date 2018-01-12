using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    class Function1
    {
        static void Main(string[] args)
        {
            double x = Vvod("x");
            double n = Vvod("n");
            double e = Vvod("e");
            double a = 1;
            double Sn = 0, Se = 0, See = 0;
            int ne = 0;
            int i = 1;
            int nee = 0;
            while (i <= n || Math.Abs(a) > e / 10)
            {
                if (i <= n)
                    Sn += a;

                if (Math.Abs(a) > e)
                {
                    Se += a;
                    ne++;
                }
                if (Math.Abs(a) > e / 10)
                {
                    See += a;
                    nee++;
                }
                i++;
                a = -(a * x * x) / (2 * i - 1) / (2 * i - 2);
            }

                Console.WriteLine("Sn = {0} и там будет {1} элементов", Sn, n);
                Console.WriteLine("Se = {0} и там будет {1} элементов", Se, ne);
                Console.WriteLine("See = {0} и там будет {1} элементов", See, nee);
                Console.WriteLine("rezult =>{0}", Math.Sin(x) / x);
            
        }
        public static double Vvod(string var)
        {
            double varname = 0;
            Console.WriteLine(var);
            varname = double.Parse(Console.ReadLine());
            return varname;
        }
    }
}
