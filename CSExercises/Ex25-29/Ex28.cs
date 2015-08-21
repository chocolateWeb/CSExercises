using System;

namespace CSExercises
{
    public class Ex28
    {
        public static void Main(string[] args)
        {
            bool isPrime = true;

            Console.Write("Enter input: ");
            int input = Convert.ToInt32(Console.ReadLine());

            if(input > 1)
            {
                for(int i = 1; i <= input; i++)
                {
                    if (input % i == 0 && i != 1 && i != input)
                    {
                        Console.WriteLine("Your input {0} is not a Prime.", input);
                        i = input;
                        isPrime = false;
                    }
                }

                if(isPrime)
                    Console.WriteLine("Your input {0} is a Prime.", input);
            }

            else
                Console.WriteLine("Your input {0} is invalid.", input);

        }
    }
}
