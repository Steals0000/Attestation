using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class StringUtility
    {
        public string Str { get; set; }
        public StringUtility(string str)
        {
            Str = str;
        }
        public string[] SplitString()
        {
            string[] words = Str.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            return words;
        }
        public bool IsPallindrom(string word)
        {
            word = word.ToLower();
            for (int i=0; i<word.Length/2; i++)
            {
                if (word[i] != word[word.Length - i - 1])
                    return false;
            }
            return true;
        }

        public string SelectPallindroms()
        {
    
           string [] words = SplitString();
            string [] checkedwords = new string [words.Length];
            int count = 0;
            foreach (string item in words)
            {
                if (IsPallindrom(item))
                {
                    checkedwords[count] = item;
                    count++;
                }
            }
            words = checkedwords;
            Array.Resize(ref words, count);
            string Output = string.Join(", ", words) + ("  Количество паллиндромов: " + count);
          return Output;
        }
    }

}

