using System;

namespace RArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 2, 4, 6, 8 };
            Array.Reverse(array);
            Console.WriteLine(string.Join(',', array));
        }
    }
}
