using System;

namespace PrimeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prime Number from 0-1000 are: ");

            for (int i = 1; i <= 1000; i++)
            {
                int div = 1;
                int count = 0;
                while (div<=i)
                {
                    if (i % div == 0)
                    {
                        count++;
                    }
                    div++;
                }

                if (count == 2)
                    Console.WriteLine(i);
            }
        }
    }
}
