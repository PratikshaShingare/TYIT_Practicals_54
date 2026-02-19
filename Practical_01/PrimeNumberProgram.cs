using System;

namespace Practical1
{
    class PrimeNumber
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Enter a number: ");
            a = Convert.ToInt32(Console.ReadLine());

            bool isPrime = true;

            for (int i = 2; i <= a / 2; i++)
            {
                if (a % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime && a > 1)
                Console.WriteLine(a + " is Prime");
            else
                Console.WriteLine(a + " is not Prime");

            Console.ReadKey();
        }
    }
}
