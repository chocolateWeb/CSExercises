using System;

namespace CSExercises
{
    public class Ex30
    {
        public static void Main(string[] args)
        {
            bool isPrime = true;

            for (int i = 5; i <= 10000; i++)
            {
                isPrime = true;

                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0 && j != 1 && i != j)
                    {
                        j = i;
                        isPrime = false;
                    }
                }
                if (isPrime)
                    Console.WriteLine("{0}", i);

            }
        }
    }
}
