using System;

namespace Practical1
{
    class Fibonacci
    {
        static void Main(string[] args)
        {
            int n, f1 = 0, f2 = 1, f3;

            Console.WriteLine("Enter limit of series: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write(f1 + " " + f2);

            for (int i = 2; i < n; i++)
            {
                f3 = f1 + f2;
                Console.Write(" " + f3);
                f1 = f2;
                f2 = f3;
            }

            Console.ReadKey();
        }
    }
}
