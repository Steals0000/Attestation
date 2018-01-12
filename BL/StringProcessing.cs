using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class StringProcessing
    {
        private T StrToValue<T>(string str)
        {
            return (T)Convert.ChangeType(str, typeof(T));
        }

        public T[] StrToArray<T>(string str)
        {
            return Array.ConvertAll(
               str.Split(new char[] { ',', ' ', ';' }, StringSplitOptions.RemoveEmptyEntries),
               (s) => StrToValue<T>(s)
           );
        }

        public string ArrayToStr<T>(T[] arr, string separator = ", ")
        {
            return arr == null ? "null" : String.Join(separator, arr);
        }

    }
}

