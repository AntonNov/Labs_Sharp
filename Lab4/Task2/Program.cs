using System;
using System.Runtime.InteropServices;
using System.Text;
namespace Task1
{
    class Program
    {
        [UnmanagedFunctionPointer(CallingConvention.StdCall,CharSet=CharSet.Ansi)]
        public delegate bool Output(string value);
        [DllImport("C:\\Homework\\2 semester\\Isp\\UnmanagedDLL\\Debug\\TestDLL.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void Print(Output output);
        static void Main(string[] args)
        {
            try
            {
                Print(PrintToConsole);
            }
            catch (DllNotFoundException e)
            {
                Console.WriteLine(e.ToString());
            }
            catch(BadImageFormatException e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        public static bool PrintToConsole(string value)
        {
            Console.WriteLine(value);
            return true;
        }
    }
}
