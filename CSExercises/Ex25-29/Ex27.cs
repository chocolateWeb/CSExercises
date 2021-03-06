using System;

namespace CSExercises
{
    public class Ex27
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("X\t\tY");
            Console.WriteLine("--------------------------------------------------------------------------------");

            for(int i = -5; i <= 5; i++)
            {
                Console.WriteLine("{0:.0}\t\t{1:.0}", i, (2 * i * i) - (4 * i) + 3);
            }

            Console.WriteLine();

            for (int i = -5; i <= 5; i++)
            {
                for (int j = 0; j < ((2 * i * i) - (4 * i) + 3) ; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}
