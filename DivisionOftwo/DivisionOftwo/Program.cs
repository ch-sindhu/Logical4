using System;

namespace DivisionOftwo
{
    class Program
    {
        static void Main(string[] args)
        {
            int num2;
            int num1;
            float result;
            Console.Write("\n \n ***  www.csharp-console-examples.com *** \n \n");
            Console.Write("Enter first number:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second number:");
            num2 = Convert.ToInt32(Console.ReadLine());
              result = num1 / num2;
            Console.Write("The division of two numbers is:" + result);

        }
    }
}
