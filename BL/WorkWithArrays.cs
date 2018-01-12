using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class WorkWithArrays
    {
        public int[] Arr { set; get; }

        public WorkWithArrays(int[] array)
        {
            Arr = array;
        }

        public double Average()
        {
            double Count = 0;
            int Counter = 0;
            for (int i = 0; i < Arr.Length; i++)
            { Count = Arr[i] + Count;
                Counter++;
            }
            return (Count / Counter);
                
        }

        public double Calculation(out double Aver)
        {
            Aver = Average();
            int Counter;
           double x1 = Math.Ceiling(Aver);
            double x2 = x1 - 1;
            if ((x1 - Aver) == (Aver - x2))
            {Counter = 2;}
            else
            {Counter = 1;}
            return Counter;
        }
    }
}
