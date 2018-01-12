using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibr
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
        public int[,] ArrayMoveRight()
        {
            int rowCount = Arr.GetLength(0);
            int colCount = Arr.GetLength(1);
            for (int i = 0; i < rowCount; i++)
                for (int j = 0; j < N; j++)
                { int Save = Arr[i, colCount - 1];
                    for (int k = colCount - 1; k > 0; k--)
                        Arr[i, k] = Arr[i,k - 1];
                             Arr[i, 0] = Save;
                        }

            return Arr;
        }
        public int[,] ArrayMoveDown()
        {
            int rowCount = Arr.GetLength(0);
            int colCount = Arr.GetLength(1);
            for (int i = 0; i < colCount; i++)
                for (int j = 0; j < N; j++)
                {
                    int Save = Arr[rowCount - 1,i];
                    for (int k = rowCount - 1; k > 0; k--)
                        Arr[k, i] = Arr[k - 1,i];
                    Arr[0,i] = Save;
                }

            return Arr;
        }
    }
}
