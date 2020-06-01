  
using System;

namespace Lab_5_Ind_1
{
    abstract class Transport
    {
        //fields
        protected static int seriesNumber;
        protected static int[] registrationNumber;
        protected string name;
        protected string color;
        protected string comfortLevel;
        protected uint yearMade;

        //properties
        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Color
        {
            get => color;
            set => color = value;
        }

        public string ComfortLevel
        {
            get => comfortLevel;
            set => comfortLevel = value;
        }

        public uint YearMade
        {
            get => yearMade;
            set
            {
                if (value > 2020 || value < 1960)
                    return;
                else
                    yearMade = value;
            }
        }

        public static int Series
        {
            get => seriesNumber;
        }


        //indexer
        public int this[int digit]
        {
            get => registrationNumber[digit];
        }

        //constructors
        public Transport()
        {
            registrationNumber = new int[4];
            Random rnd = new Random();
            foreach (int digit in registrationNumber)
            {
                registrationNumber[digit] = rnd.Next(0, 9);
            }
            seriesNumber = rnd.Next(1000, 10000);
        }

        //destructor
        ~Transport() { }
    }
}

