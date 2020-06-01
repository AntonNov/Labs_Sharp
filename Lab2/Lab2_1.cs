using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2_1
{
    class Program
    {
        static void Main(string[] args)
        {

            string str = Convert.ToString(DateTime.Now);
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.WriteLine(DateTime.Now.ToShortTimeString());
            Console.WriteLine(DateTime.Now.ToString("D"));
            Console.WriteLine(DateTime.Now.ToString("ddd.MMM.yy.g") + " " + DateTime.Now.ToString("K:hh:mm:ss:f"));

            for (char i = '1'; i <= '9'; i++)
            {
                int counter = 0;
                for (int j = 0; j < str.Length; j++)
                {
                    if (str[j] == i)
                    {
                        counter++;
                    }

                }
                Console.WriteLine($"Количество {i} = {counter}");
            }
        }

    }
}
