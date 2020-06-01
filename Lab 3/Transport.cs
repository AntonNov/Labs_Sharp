
using System;

namespace Lab3Ind1
{
    //TODO:

    class Transport
    {
        //fields
        private double fuel = 0;
        private string type;
        private string mark;
        private uint yearMade;
        private uint capacity;
        private uint power;
        private uint maxSpeed;
        private int currentSpeed = 0;

        //constructors
        public Transport(string transType, string transMark, uint year, uint transCapacity, uint transPower, uint transMax)
        {
            type = transType;
            mark = transMark;
            yearMade = year;
            capacity = transCapacity;
            power = transPower;
            maxSpeed = transMax;
        }

        public Transport()
        {
            type = "NULL";
            mark = "NULL";
            yearMade = 0;
            power = 0;
            maxSpeed = 0;
            currentSpeed = 0;
        }

        //destructor
        ~Transport()
        {
            Console.WriteLine("PEPEG!!!");
        }

        //properties
        public string Type
        {
            get
            { return type; }
            set
            { type = value; }
        }

        public string Mark
        {
            get { return mark; }
            set { mark = value; }
        }

        public uint year
        {
            get { return yearMade; }
            set
            {
                if (value <= 2020)
                    yearMade = value;
                else
                    Console.WriteLine("Error. The year must be less than 2021.");
            }
        }

        public uint Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }

        public uint Power
        {
            get { return power; }
            set { power = value; }
        }

        public double Fuel
        {
            get { return fuel; }
        }

        public uint Maxspeed
        {
            get { return maxSpeed; }
            set { maxSpeed = value; }
        }

        public int Currentspeed
        {
            get { return currentSpeed; }
            set
            {
                if (currentSpeed + value < maxSpeed)
                    currentSpeed = value;
                else
                    Console.WriteLine("Error. You can't speed up so much.");
            }
        }

        //Methods
        public void Beep()
        {
            Console.WriteLine("BEEP!\a");
        }

        public void Refuel(uint amount)
        {
            if (fuel + amount <= capacity)
                fuel += amount;
            else
                Console.WriteLine("Error. The amount of fuel you'd like to add is above the transport's capacity.");
        }

        public double Calculate(int position)
        {
            return fuel / position * 100;
        }

        public int Move(int position)
        {
            int total = 0;
            double cost = Calculate(position);
            double temporary = Math.Abs(fuel - cost);

            if (fuel < cost)
            {
                if (fuel < temporary)
                {
                    Console.WriteLine("Error. You don't have enough fuel. You aren't able to move.");
                    return 0;
                }

                while (fuel > 0)
                {
                    fuel -= temporary;
                    total += currentSpeed;
                }

                Console.WriteLine($"Error. You don't have enough fuel. You'll be able to move only for: {total} units.");
                return total;
            }

            else
            {
                while (cost > 0)
                {
                    cost -= temporary;
                    total += currentSpeed;
                }
                return total;
            }

        }

        public void ShowInfo()
        {
            Console.WriteLine($"Type: {type}");
            Console.WriteLine($"Mark: {mark}");
            Console.WriteLine($"Year of production: {yearMade}");
            Console.WriteLine($"Capacity: {capacity}");
            Console.WriteLine($"Fuel: {fuel}");
            Console.WriteLine($"Power: {power}");
            Console.WriteLine($"Maximum speed: {maxSpeed}");
            Console.WriteLine($"Current speed: {currentSpeed}");
        }
    }
}