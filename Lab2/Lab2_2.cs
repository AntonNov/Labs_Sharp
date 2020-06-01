using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Lab2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите  язык ( ru, en, fr, de): ");
            string cultureSymbol = Console.ReadLine();
            try
            {
                CultureInfo culture = new CultureInfo(cultureSymbol);
                if (!CultureInfo.GetCultures(CultureTypes.AllCultures).Contains(culture))
                    throw new Exception("Неверный язык");
                foreach (var month in culture.DateTimeFormat.MonthNames)
                {
                    Console.WriteLine(month);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           
        }
    }
}

