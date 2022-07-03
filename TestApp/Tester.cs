using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    internal class Tester
    {
        public void TestingTesting()
        {
            Console.Write("Enter coefficient of a: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter coefficient of b: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter coefficient of c: ");
            int c = int.Parse(Console.ReadLine());

            double discriminant = b * b - 4 * a * c;
            double x1;
            double x2;

            if (discriminant == 0)
            {
                x1 = -b / 4 * a * c;
                Console.WriteLine($"the real root is {x1}");
            }
            else if (discriminant > 0)
            {
                x1 = -b - Math.Sqrt(discriminant) / 2 * a;
                x2 = -b + Math.Sqrt(discriminant) / 2 * a;
                Console.WriteLine($"the roots of the equations are {x1} and {x2}");
            }
            else
            {
                Console.WriteLine("it has no reall root");
            }
        }
    }
}
