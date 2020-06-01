  
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Fraction : IComparable<Fraction>
    {
        public int Numerator { get; private set; }
        public int Denominator { get; private set; }

        public Fraction(int numerator, int denominator)
        {
            this.Numerator = numerator;
            this.Denominator = denominator;
            Reduction();
        }
        private int CounterUnderscores(int value)
        {
            int counter = 1;
            while (Math.Abs(value) > 0)
            {
                value /= 10;
                counter++;
            }
            return counter;
        }

        public string Format(Fraction data)
        {
            string result = "";
            int count;
            count = (CounterUnderscores(data.Denominator)) < (CounterUnderscores(data.Numerator)) ? (CounterUnderscores(data.Numerator)) : (CounterUnderscores(data.Denominator));
            result += data.Numerator + "\n";
            for (int i = 1; i < count; i++)
                result += "_";
            result += " == " + (double)data;
            result += "\n\n" + data.Denominator;
            return result;
        }
        private static int NOD(int a, int b)
        {
            if (b == 0)
                return a;
            else
                return NOD(b, a % b);
        }
        private static int NOK(int a, int b)
        {
            return Math.Abs(a) * Math.Abs(b) / NOD(a, b);
        }
        private void Reduction()
        {
            if (Numerator != 0)
            {
                int nod = NOD(Numerator, Denominator);
                Numerator /= nod;
                Denominator /= nod;
            }
        }

        public int CompareTo(Fraction y)
        {
            int nok = NOK(this.Denominator, y.Denominator);
            if ((this.Numerator * nok / this.Denominator) > (y.Numerator * nok / y.Denominator))
                return 1;
            if ((this.Numerator * nok / this.Denominator) < (y.Numerator * nok / y.Denominator))
                return -1;
            else
                return 0;
        }

        public override string ToString()
        {
            int count;
            string result = "";
            if (Numerator != 0 && Denominator != 1)
            {
                count = (CounterUnderscores(Denominator)) < (CounterUnderscores(Numerator)) ? (CounterUnderscores(Numerator)) : (CounterUnderscores(Denominator));
                result += Numerator + "\n";
                for (int i = 1; i < count; i++)
                    result += "_";
                result += "\n\n" + Denominator;
                return result;
            }
            else
            {
                if (Numerator == 0)
                {
                    result += 0;
                    return result;
                }
                if (Denominator == 1)
                {
                    result += Numerator;
                    return result;
                }
            }
            return null;
        }
        public static Fraction operator +(Fraction num1, Fraction num2)
        {
            if (num1.Denominator != num2.Denominator)
            {
                int nok = NOK(num1.Denominator, num2.Denominator);
                return new Fraction((num1.Numerator * nok / num1.Denominator) + (num2.Numerator * nok / num2.Denominator), nok);
            }
            else
                return new Fraction(num1.Numerator + num2.Numerator, num1.Denominator);
        }
        public static Fraction operator -(Fraction num1, Fraction num2)
        {
            if (num1.Denominator != num2.Denominator)
            {
                int nok = NOK(num1.Denominator, num2.Denominator);
                return new Fraction((num1.Numerator * nok / num1.Denominator) - (num2.Numerator * nok / num2.Denominator), nok);
            }
            else
                return new Fraction(num1.Numerator - num2.Numerator, num1.Denominator);
        }
        public static Fraction operator *(Fraction num1, Fraction num2)
        {
            return new Fraction(num1.Numerator * num2.Numerator, num1.Denominator * num2.Denominator);
        }
        public static Fraction operator /(Fraction num1, Fraction num2)
        {
            return new Fraction(num1.Numerator * num2.Denominator, num1.Denominator * num2.Numerator);
        }
        public static Fraction operator ++(Fraction num1)
        {
            return new Fraction(num1.Numerator + num1.Denominator, num1.Denominator);
        }
        public static Fraction operator --(Fraction num1)
        {
            return new Fraction(num1.Numerator - num1.Denominator, num1.Denominator);
        }
        public static bool operator <(Fraction num1, Fraction num2)
        {
            int nok = NOK(num1.Denominator, num2.Denominator);
            return (num1.Numerator * nok / num1.Denominator) < (num2.Numerator * nok / num2.Denominator);

        }
        public static bool operator >(Fraction num1, Fraction num2)
        {
            int nok = NOK(num1.Denominator, num2.Denominator);
            return (num1.Numerator * nok / num1.Denominator) > (num2.Numerator * nok / num2.Denominator);

        }
        public static bool operator <=(Fraction num1, Fraction num2)
        {
            int nok = NOK(num1.Denominator, num2.Denominator);
            return (num1.Numerator * nok / num1.Denominator) >= (num2.Numerator * nok / num2.Denominator);
        }
        public static bool operator >=(Fraction num1, Fraction num2)
        {
            int nok = NOK(num1.Denominator, num2.Denominator);
            return (num1.Numerator * nok / num1.Denominator) >= (num2.Numerator * nok / num2.Denominator);
        }

        public static explicit operator double(Fraction data)
        {
            return (double)data.Numerator / data.Denominator;
        }
        public static implicit operator Fraction(double value)
        {
            int i = 0, j = 10;
            while (value * Math.Pow(10, 1 + i) % 10 != 0) { i++; }
            int denominator = (int)Math.Pow(j, i);
            int numerator = (int)(value * denominator);
            int nod = NOD((int)(value * Math.Pow(10, i)), denominator);
            return new Fraction(numerator / nod, denominator / nod);
        }
    }
}
