using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            int numerator = 0, denominator = 0;
            Fraction second, first;
            Console.WriteLine("Enter first fraction:");
            bool temp = true;

            while (temp)
            {
                for (byte i = 0; i < 1; i++)
                {
                    Console.Clear();
                    try
                    {
                        Console.WriteLine("Numerator:");
                        numerator = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Deniminator:");
                        denominator = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception ex)
                    {
                        Console.Clear();
                        Console.WriteLine(ex.Message);
                        Console.WriteLine("Wrong type! Try again:");
                        i--;
                    }
                }
                if (denominator != 0)
                {
                    temp = false;
                }
            }
            first = new Fraction(numerator, denominator);
            temp = true;
            Console.WriteLine("Enter second fraction:");

            while (temp)
            {
                for (byte i = 0; i < 1; i++)
                {
                    Console.Clear();
                    try
                    {
                        Console.WriteLine("Numerator:");
                        numerator = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Deniminator:");
                        denominator = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception ex)
                    {
                        Console.Clear();
                        Console.WriteLine(ex.Message);
                        Console.WriteLine("Wrong type! Try again:");
                        i--;
                    }
                }
                if (denominator != 0)
                {
                    temp = false;
                }
            }
            second = new Fraction(numerator, denominator);
            //first = 0.25;
            //second = 0.75;
            Fraction result;
            temp = true;
            while (temp)
            {
                Console.Clear();
                Console.WriteLine("Summ -  +");
                Console.WriteLine("Subtraction -  -");
                Console.WriteLine("Multiplication -  *");
                Console.WriteLine("Division -   /");
                Console.WriteLine("Format -   f");
                switch (Convert.ToChar(Console.ReadLine()))
                {
                    case '+':
                        result = first + second;
                        
                        Console.WriteLine(result.ToString());
                        Console.ReadKey();
                        break;
                    case '-':
                        result = first - second;
                        
                        Console.WriteLine(result.ToString());
                        Console.ReadKey();
                        break;
                    case '*':
                        result = first * second;
                        
                        Console.WriteLine(result.ToString());
                        Console.ReadKey();
                        break;
                    case '/':
                        result = first / second;
                        
                        Console.WriteLine(result.ToString());
                        Console.ReadKey();
                        break;
                    case 'f':
                        Console.WriteLine(first.Format(first));
                        Console.WriteLine();
                        Console.WriteLine(second.Format(second));
                        Console.ReadKey();
                        break;
                    default:
                        return;
                }
            }

        }


    }
}