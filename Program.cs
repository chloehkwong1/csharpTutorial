using System;

namespace csharpTutorial
{
    class Program
    {
        static void WorkingWithIntegers()
        {
            int a = 19;
            int b = 6;

            // addition
            int c = a + b;
            Console.WriteLine(c);

            // subtraction
            c = a - b;
            Console.WriteLine(c);

            // multiplication
            c = a * b;
            Console.WriteLine(c);

            // division
            c = a / b;
            Console.WriteLine(c);
        }

        static void RemaindersAndQuotients()
        {
            int a = 7;
            int b = 4;
            int c = 3;
            int d = (a + b) / c;
            int e = (a + b) % c;
            Console.WriteLine($"quotient: {d}");
            Console.WriteLine($"remainder: {e}");
        }

        static void TestLimits()
        {
            int max = int.MaxValue;
            int min = int.MinValue;
            Console.WriteLine($"The range of integers is {min} to {max}");

            int what = max + 3;
            Console.WriteLine($"An example of overflow: {what}");
            //WorkingWithIntegers();
        }

        static void Doubles()
        {
            double a = 5;
            double b = 4;
            double c = 2;
            double d = (a + b) / c;
            Console.WriteLine(d);

            double e = 19;
            double f = 23;
            double g = 8;
            double h = (e + f) / g;
            Console.WriteLine(h);

            double min = double.MinValue;
            double max = double.MaxValue;
            Console.WriteLine($"The range of the double is {min} to {max}");

            double third = 1.0 / 3.0;
            Console.WriteLine(third);
        }
        
        static void Decimal()
        {
            decimal min = decimal.MinValue;
            decimal max = decimal.MaxValue;
            Console.WriteLine($"The range of the decimal type is {min} to {max}");

            double a = 1.0;
            double b = 3.0;
            Console.WriteLine(a / b);

            decimal c = 1.0M;
            decimal d = 3.0M;
            Console.WriteLine(c / d);
        }

        static void AreaOfCircle()
        {
            double radius = 2.50;
            double area = radius * radius * Math.PI;
            Console.WriteLine(area);
        }

        static void Main(string[] args)
        {
            AreaOfCircle();
        }
    }
}
