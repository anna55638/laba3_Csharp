using System;

namespace laba3_Csharp
{
    public class Fraction
    {
        public int Numerator { get; private set; }
        public int Denominator { get; private set; }

        public Fraction(int numerator, int denominator)
        {
            if (denominator == 0)
                throw new ArgumentException("Denominator cannot be zero.");

            Numerator = numerator;
            Denominator = denominator;
            Simplify();
        }

        private void Simplify()
        {
            int gcd = GCD(Math.Abs(Numerator), Math.Abs(Denominator));
            Numerator /= gcd;
            Denominator /= gcd;

            if (Denominator < 0)
            {
                Numerator *= -1;
                Denominator *= -1;
            }
        }

        private int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        public Fraction Add(Fraction other)
        {
            int newNumerator = Numerator * other.Denominator + other.Numerator * Denominator;
            int newDenominator = Denominator * other.Denominator;
            return new Fraction(newNumerator, newDenominator);
        }

        public Fraction Subtract(Fraction other)
        {
            int newNumerator = Numerator * other.Denominator - other.Numerator * Denominator;
            int newDenominator = Denominator * other.Denominator;
            return new Fraction(newNumerator, newDenominator);
        }

        public Fraction Multiply(Fraction other)
        {
            int newNumerator = Numerator * other.Numerator;
            int newDenominator = Denominator * other.Denominator;
            return new Fraction(newNumerator, newDenominator);
        }

        public Fraction Divide(Fraction other)
        {
            if (other.Numerator == 0)
                throw new DivideByZeroException("Cannot divide by zero.");

            int newNumerator = Numerator * other.Denominator;
            int newDenominator = Denominator * other.Numerator;
            return new Fraction(newNumerator, newDenominator);
        }

        public int CompareTo(Fraction other)
        {
            int crossProduct1 = Numerator * other.Denominator;
            int crossProduct2 = other.Numerator * Denominator;

            if (crossProduct1 < crossProduct2)
                return -1;
            else if (crossProduct1 > crossProduct2)
                return 1;
            else
                return 0;
        }

        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }
    }
}