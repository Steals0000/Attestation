using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class ArrayUtility
    {
        public int[,] Arr { get; set; }
        public int N { get; set; }
        public ArrayUtility(int[,] arr, int n)
        {
            Arr = arr;
            N = n;
        }
        public int[,] Array(int[,] arr, int n)
        {

            int rowCount = arr.GetLength(0);
            int colCount = arr.GetLength(1);
            return arr;
        }



     }
}
