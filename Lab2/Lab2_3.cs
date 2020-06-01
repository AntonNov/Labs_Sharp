using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder str = new StringBuilder(Console.ReadLine());
            bool exist = false;
            for(int i = 1; i < str.Length; i++)
            {
                if ((Char.IsPunctuation(str[i]) && !Char.IsWhiteSpace(str[i - 1])) && (i == str.Length - 1 || Char.IsWhiteSpace(str[i + 1]))) { 
                    int count = i;
                    while (!Char.IsWhiteSpace(str[count]) && count != 0)
                    {
                        count--;
                    }
                    if(count != 0)
                    {
                        count++;
                    }
                    exist = true;
                    str.Insert(count, str[i]);
                    i++;
                }
            }
            if (!exist)
            {
                Console.WriteLine("There are no punctuation marks.");
            }
            Console.WriteLine(str);
        }
    }
}
