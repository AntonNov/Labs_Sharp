  
using System;
using Lab_6_Ind_1;

namespace Lab_5_Ind_1
{
    class Car : Transport, IComparable
    {
        //fields
        protected uint price = 0;
        protected uint numberOfSeats;
        protected uint trunkSize;

        public enum CarType
        {
            Sedan,
            Universal,
            Hatchback,
            Pickup,
            Crossover,
            SUV
        }

        public struct Engine
        {
            private uint volume;
            private uint power;
            private uint cylinders;
            private string ecoClass;
            public Engine(uint volume, uint cylinders, uint power, string ecoClass)
            {
                this.volume = volume;
                this.cylinders = cylinders;
                this.power = power;
                this.ecoClass = ecoClass;
            }

            public uint Volume
            {
                get => volume;
            }

            public uint Power
            {
                get => power;
            }

            public uint Cylinders
            {
                get => cylinders;
            }

            public string EcoClass
            {
                get => ecoClass;
            }
        }

        //properties
        public uint Price
        {
            get => price;
            set => price = value;
        }

        public uint Seats
        {
            get => numberOfSeats;
            set => numberOfSeats = value;
        }

        public uint TrunkSize
        {
            get => trunkSize;
            set => trunkSize = value;
        }

        //constructors
        public Car()
        {
            price = 0;
            numberOfSeats = 0;
            trunkSize = 0;
        }

        //destructor
        ~Car() { Console.WriteLine("KEKW!"); }

        //methods
        public virtual void Beep() { Console.WriteLine("BEEP!\a"); }

        public void Calculate()
        {
            price = numberOfSeats * 2000 + trunkSize * 2;
            if (comfortLevel == "high")
                price *= 3;
            else if (comfortLevel == "medium")
                price *= 2;
        }

        //IComparable implementation
        public int CompareTo(object o)
        {
            Car c = o as Car;
            if (c != null)
                return this.Price.CompareTo(c.Price);
            else
                throw new Exception("Error. Unable to compare these objects.");
        }
    }
}

