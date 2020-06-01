namespace Lab_8_Ind_1
{
    class Program
    {
        public delegate Car Choose(Car first, Car second);

        delegate void MessageHandler(string message);

        static void Main(string[] args)
        {
            BMW myCar = new BMW("Auto", "Black", "high", 2019, 4, 80, BMW.Model.M3, Car.CarType.Sedan);
            BMW.Engine myEngine = new BMW.Engine(2500, 6, 80, "EURO 0");
            myCar.Calculate();

            Mercedes friendsCar = new Mercedes("Auto", "Silver", "medium", 2012, 4, 400, Mercedes.Model.W140,
                Car.CarType.Sedan);
            Mercedes.Engine friendsEngine = new Mercedes.Engine(1700, 4, 66, "EURO 5");
            friendsCar.Calculate();

            Choose choice = IsBetter;
            MessageHandler handler = delegate (string message) { Console.WriteLine("message"); };



            handler("Enter the sum you would like to add:");
            int money;
            try
            {
                Int32.TryParse(Console.ReadLine(), out money);
                if (money <= 0)
                    throw new Exception("You've entered invalid data!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            myCar.Purchase(money);
            friendsCar.Purchase(money);

            var result = choice(myCar, friendsCar);
            handler("Nice choice!");
        }

        public static Car IsBetter(Car first, Car second)
        {
            int firstPoints = 0;
            int secondPoints = 0;

            if (first.Seats > second.Seats)
                firstPoints++;
            else if (first.Seats < second.Seats)
                secondPoints++;
            else
            {
                firstPoints++;
                secondPoints++;
            }


            if (first.ComfortLevel == "high" && (second.ComfortLevel == "medium" || second.ComfortLevel == "low") ||
                first.ComfortLevel == "medium" && second.ComfortLevel == "low")
                firstPoints++;
            else if (first.ComfortLevel == second.ComfortLevel)
            {
                firstPoints++;
                secondPoints++;
            }
            else
                secondPoints++;


            if (first.YearMade > second.YearMade)
                firstPoints++;
            else if (first.YearMade == second.YearMade)
            {
                firstPoints++;
                secondPoints++;
            }
            else
                secondPoints++;

            if (firstPoints > secondPoints)
                return first;
            else if (firstPoints == secondPoints)
            {
                Console.WriteLine("The cars are equal, which one would like to choose?");
                int choice;
                Int32.TryParse(Console.ReadLine(), out choice);
                switch (choice)
                {
                    case 1:
                        {
                            return first;
                        }

                    case 2:
                        {
                            return second;
                        }

                    default:
                        {
                            Console.WriteLine("Error!");
                            break;
                        }
                }
            }
            else
                return second;

            return null;
        }
    }
}
