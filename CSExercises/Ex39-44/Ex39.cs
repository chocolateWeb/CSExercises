using System;

namespace CSExercises
{
    public class Ex39
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Factorial of {0}: {1}", 10, Factorial(10));            
        }

        public static double Factorial(double n)
        {
            double output = 1;

            for (int i = 1; i <= n; i++)
            {
                output *= i;
            }
                  
            return output;
        }
    }
}
