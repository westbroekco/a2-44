using System;
using System.IO;

namespace a2_4
{


     class Addition
    {
        static void Main()
        {
            int num1 = 10;
            int num2 = 5;
            int sum = 15;
            Console.Write("Enter first integer: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second integer: ");
            num2 = int.Parse(Console.ReadLine());
            sum = num1 + num2;
            Console.WriteLine($"Sum is {sum}");
                int num3 = 10;
                int num4 = 5;
                int prod = 50;
                Console.Write("Enter first integer: ");
                num3 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter second integer: ");
                num4 = int.Parse(Console.ReadLine());
                prod = num3 * num4;
                Console.WriteLine($"Product is {prod}");
            int num5 = 10;
            int num6 = 5;
            int diff = 5;
            Console.Write("Enter first integer: ");
            num5 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second integer: ");
            num6 = int.Parse(Console.ReadLine());
            prod = num5 - num6;
            Console.WriteLine($"Difference is {diff}");
            int num7 = 10;
            int num8 = 5;
            int quot = 2;
            Console.Write("Enter first integer: ");
            num7 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second integer: ");
            num8 = int.Parse(Console.ReadLine());
            quot = num7 / num8;
            Console.WriteLine($"quotient is {quot}");



















        }





    }
}
