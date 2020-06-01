
using System;

namespace Lab_6_Ind_1
{
    interface IMovable
    {
        public const int minSpeed = 0;
        private static int maxSpeed = 80;

        public int MaxSpeed
        {
            get { return maxSpeed; }
            set { maxSpeed = value; }
        }

        public double GetTime(double distance, double speed) => distance / speed;

    }
}
