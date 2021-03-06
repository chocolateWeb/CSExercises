using System;

namespace CSExercises
{
    public class Ex26
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("NO\t\tINVERSE\t\t\tSQUARE ROOT\t\tSQUARE");
            Console.WriteLine("--------------------------------------------------------------------------------");

            for(double i = 1.0; i <= 10.0; i++)
            {
                Console.WriteLine("{0:.0}\t\t{1: 0.0##}\t\t\t{2: 0.0##}\t\t\t{3: 0.0##}", i, 1/i, Math.Sqrt(i), i * i);
            }
        }
    }
}
