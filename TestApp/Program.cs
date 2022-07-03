using System;

namespace TestApp
{
    class Program
    {
        int count = 0;
        static void Main(string[] args)
        {
            /*int result = MyMethod();
            Console.WriteLine(result);

            double result2 = MyMethod2(55.8, 44);
            Console.WriteLine(result2);

            double result3 = MyMethod2(123, 98.02);
            Console.WriteLine(result3);

            Console.Write("Enter your username: ");
            string userName = Console.ReadLine();
            string output = MyMethod3(userName);
            Console.WriteLine(output);*/

            Console.Write("Enter the number to get the mutiplication for: ");
            int number = int.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("How many times? ");
            int times = int.Parse(Console.ReadLine());
            Console.Clear();

            PrintMultiplicationTable(number, times);
        }

        static int MyMethod()
        {
            return 2 + 2;
        }

        static double MyMethod2(double num1, double num2)
        {
            return num1 + num2;
        }

        static string MyMethod3(string userName)
        {
            return $"Hello {userName}, welcome to MGQS.";
        }

        static void PrintMultiplicationTable(int number, int times)
        {
            for(int i = 1; i <= times; i++)
            {
                Console.WriteLine($"{number} * {i} = {number * i}");
            }
        }
    }
}
