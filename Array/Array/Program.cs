using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5 };
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
