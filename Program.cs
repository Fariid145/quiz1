using System;

namespace QuadraticEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;
            double root1, root2;
            Console.WriteLine("Enter a, b and c where a*x*x + b*x + c = 0");
            d = b * b - 4 * a * c;
            if (d < 0)
            { // complex roots, i is for iota (√-1, square root of -1)
                Console.WriteLine("First root = %.2lf + i%.2lf", -b / (double)(2 * a), sqrt(-d) / (2 * a));
                Console.WriteLine("Second root = %.2lf - i%.2lf", -b / (double)(2 * a), sqrt(-d) / (2 * a));
            }
            else
            { // real roots
                root1 = (-b + sqrt(d)) / (2 * a);
                root2 = (-b - sqrt(d)) / (2 * a);

                Console.WriteLine("First root = %.2lf", root1);
                Console.WriteLine("Second root = %.2lf", root2);
            }

            return 0;
        }
    }
}
