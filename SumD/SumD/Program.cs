using System;

namespace SumD
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0, m;
            Console.WriteLine("Enter a number");
            int no = int.Parse(Console.ReadLine());
            while(no>0)
            {
                m = no % 10;
                sum = sum + m;
                no = no / 10;
            }
            Console.WriteLine("Sum is " + sum);

        }
    }
}
