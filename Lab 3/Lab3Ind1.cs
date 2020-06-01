using System;

namespace Lab3Ind1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Enter the data of your transport!\n");

            Console.Write("First of all, the transport's type: ");
            string type = Console.ReadLine();

            Console.Write("\nNow, enter it's mark: ");
            string mark = Console.ReadLine();

            Console.Write("\nThe year your vehicle was made: ");
            uint year;
            bool success;
            do
            {
                success = UInt32.TryParse(Console.ReadLine(), out year);
                if (!success)
                    Console.Write("Error. Please, enter the year once again: ");
                else
                    Console.WriteLine("Okay!\n");
            } while (success == false);

            Console.Write("Your transport's capacity: ");
            uint capacity;
            do
            {
                success = UInt32.TryParse(Console.ReadLine(), out capacity);
                if (!success)
                    Console.Write("Error. Please, enter the capacity once again: ");
                else
                    Console.WriteLine("Okay!\n");
            } while (success == false);

            Console.Write("Now, the vehicle's power: ");
            uint power;
            do
            {
                success = UInt32.TryParse(Console.ReadLine(), out power);
                if (!success)
                    Console.Write("Error. Please, enter the capacity once again: ");
                else
                    Console.WriteLine("Okay!\n");
            } while (success == false);

            Console.Write("And, the vehicle's maximum speed: ");
            uint max;
            do
            {
                success = UInt32.TryParse(Console.ReadLine(), out max);
                if (!success)
                    Console.Write("Error. Please, enter the capacity once again: ");
                else
                    Console.WriteLine("Okay!\n");
            } while (success == false);

            Transport vehicle = new Transport(type, mark, year, capacity, power, max);

            int decision = 0;
            int position = 0;
            bool correct;
            do
            {
                Console.Clear();
                ShowMenu();

                do
                {
                    correct = Int32.TryParse(Console.ReadLine(), out decision);
                    if (!success)
                        Console.Write("Error. Please, enter your choice once again: ");
                    else
                        Console.WriteLine("Okay!\n");

                } while (correct == false);

                Console.Clear();
                switch (decision)
                {
                    case 1:
                        {
                            vehicle.ShowInfo();
                            Console.WriteLine($"Position: {position}\n");
                            Console.ReadKey();
                            break;
                        }

                    case 2:
                        {
                            uint amount = 0;
                            Console.Write("How much fuel you would like to add: ");
                            if (!UInt32.TryParse(Console.ReadLine(), out amount))
                            {
                                Console.WriteLine("Error.\n");
                                break;
                            }
                            vehicle.Refuel(amount);
                            Console.ReadKey();
                            break;
                        }

                    case 3:
                        {
                            int speed = 0;
                            Console.Write("How much speed you would like to add/subtract: ");
                            if (!Int32.TryParse(Console.ReadLine(), out speed))
                            {
                                Console.WriteLine("Error.\n");
                                break;
                            }
                            vehicle.Currentspeed = speed;
                            Console.ReadKey();
                            break;
                        }

                    case 4:
                        {
                            int coordinate = 0;
                            if (!Int32.TryParse(Console.ReadLine(), out coordinate))
                            {
                                Console.WriteLine("Error.\n");
                                break;
                            }
                            position = vehicle.Move(coordinate);
                            Console.ReadKey();
                            break;
                        }
                }

            } while (decision != 5);
        }

        static void ShowMenu()
        {
            Console.WriteLine("You can do the following: ");
            Console.WriteLine("1. Check the status of your vehicle.");
            Console.WriteLine("2. Refuel your vehicle");
            Console.WriteLine("3. Speed up or slow down.");
            Console.WriteLine("4. Move forward or backward.");
            Console.WriteLine("5. Exit.");
        }
    }
}

