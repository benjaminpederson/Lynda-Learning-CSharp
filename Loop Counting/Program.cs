using System;

namespace LoopCounting
{
    class Program
    {
        static void Main(string[] args)
        {
            var repeat = 0;

            while (repeat < 5)
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine(i);
                }

                for (int i = 10; i >= 1; i--)
                {
                    Console.WriteLine(i);
                }

                repeat++;
            }
            Console.WriteLine("Iterations, {0}", repeat);

        }
    }
}
