
using System;

namespace Lab_5_Ind_1
{
    class Example
    {
        static void Main(string[] args)
        {
            BMW myCar = new BMW("Auto", "Black", "high", 2019, 4, 80, BMW.Model.M3, Car.CarType.Sedan);
            BMW.Engine myEngine = new BMW.Engine(2500, 6, 80, "EURO 0");
            myCar.Calculate();

            Console.WriteLine("The info about the vehicle:");
            Console.WriteLine($"1. Type: {myCar.Name}.\n2. Color: {myCar.Color}\n3. Year of production: {myCar.YearMade}");
            Console.WriteLine($"4. Model: {myCar.CurrentModel}\n5. Car Type: {myCar.CurrentType}\n6. Comfort level: {myCar.ComfortLevel}]n\n");

            Console.WriteLine("The vehicle's technical characteristics: ");
            Console.WriteLine($"1. Number of seats: {myCar.Seats}\n2. Engine volume: {myEngine.Volume}\n3. Engine cylinders number: {myEngine.Cylinders}");
            Console.WriteLine($"4. Engine power: {myEngine.Power}\n5. Engine ecology class: {myEngine.EcoClass}\n");
            Console.WriteLine($"The price is {myCar.Price}\n\n");

            Mercedes friendsCar = new Mercedes("Auto", "Silver", "medium", 2012, 4, 400, Mercedes.Model.W140, Car.CarType.Sedan);
            Mercedes.Engine friendsEngine = new Mercedes.Engine(1700, 4, 66, "EURO 5");
            friendsCar.Calculate();

            Console.WriteLine("The info about your friend's vehicle:");
            Console.WriteLine($"1. Type: {friendsCar.Name}.\n2. Color: {friendsCar.Color}\n3. Year of production: {friendsCar.YearMade}");
            Console.WriteLine($"4. Model: {friendsCar.CurrentModel}\n5. Car Type: {friendsCar.CurrentType}\n6. Comfort level: {friendsCar.ComfortLevel}\n\n");

            Console.WriteLine("The vehicle's technical characteristics: ");
            Console.WriteLine($"1. Number of seats: {friendsCar.Seats}\n2. Engine volume: {friendsEngine.Volume}\n3. Engine cylinders number: {friendsEngine.Cylinders}");
            Console.WriteLine($"4. Engine power: {friendsEngine.Power}\n5. Engine ecology class: {friendsEngine.EcoClass}\n");
            Console.WriteLine($"The price is {friendsCar.Price}\n\n");
        }
    }
}

