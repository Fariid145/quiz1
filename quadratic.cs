using System;
namespace QuadraticEquation
{
    public class quadratic
    {
        public static void Solve(double a, double b, double c)
        {
            double squirt = b * b - 4 * a * c;
            double root, root1, root2, imaginary;

            if(squirt > 0)
            {
                root1 = (-b + System.Math.Sqrt(squirt)) / (2 * a);
                root2 = (-b - System.Math.Sqrt(squirt)) / (2 * a);

                Console.WriteLine("Two real Solution: {0,8:f4} or {1,8:f4}", root1, root2);
            }
            else if(squirt < 0)
            {
                squirt = -squirt;
                root = -b / (2 * a);
                imaginary = System.Math.Sqrt(squirt) / (2 * a);
                Console.WriteLine("Two imaginary solution: {0,8:f4} + {1,8: f4} i or {2,8:f4} + {3,8:f4} i", root, imaginary, root, imaginary);
            }
            else 
            {
                root = (-b + System.Math.Sqrt(squirt)) / (2 * a);
                Console.WriteLine("One real solution: {0,8:f4}", root);
            }
        }

    }
}