using System;

namespace CSExercises
{
    public class Ex25
    {
        public static void Main(string[] args)
        {
            int n = 1;

            Console.Write("Enter input: ");
            int input = Convert.ToInt32(Console.ReadLine());            

            for(int i = 1; i <= input; i++)
            {
                n *= i;
            }

            Console.WriteLine("Factorial of {0}: {1}", input, n);

            n = 1;

            for (int i = input; i >= 1; i--)
            {
                n *= i;
            }

            Console.WriteLine("Factorial of {0}: {1}", input, n);
        }
    }
}
