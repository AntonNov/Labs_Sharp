using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class Scoreboard
    {
        public int countOfFirstPlayer { get; set; } = 0;

        public int countOfComputer { get; set; } = 0;

        public static int height { get; } = 9;

        public void Draw(string temp = "??")
        {

            int i = 0;

            Console.SetCursorPosition(Console.WindowWidth / 2 - 5, i);

            Console.WriteLine("##########");

            Console.SetCursorPosition(Console.WindowWidth / 2 - 5, ++i);

            Console.WriteLine("#   YOU  #");

            Console.SetCursorPosition(Console.WindowWidth / 2 - 5, ++i);

            if (countOfFirstPlayer < 10)

                Console.WriteLine($"#   {countOfFirstPlayer}    #");
            else

                Console.WriteLine($"#   {countOfFirstPlayer}   #");


            Console.SetCursorPosition(Console.WindowWidth / 2 - 5, ++i);

            Console.WriteLine("#        #");

            Console.SetCursorPosition(Console.WindowWidth / 2 - 5, ++i);
            
            Console.WriteLine("----------");

            Console.SetCursorPosition(Console.WindowWidth / 2 - 5, ++i);

            Console.WriteLine("#   PC   #");

            Console.SetCursorPosition(Console.WindowWidth / 2 - 5, ++i);

            Console.WriteLine($"#   {temp}   #");

            Console.SetCursorPosition(Console.WindowWidth / 2 - 5, ++i);

            Console.WriteLine("#        #");

            Console.SetCursorPosition(Console.WindowWidth / 2 - 5, ++i);

            Console.WriteLine("##########");

        }
    }

}
