using System;

namespace CSExercises
{
    public class Ex29
    {
        public static void Main(string[] args)
        {
            int sum = 0;

            Console.Write("Enter input: ");
            int input = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < input; i++)
            {
                if(input % i == 0)
                    sum += i;
            }

            if (input == sum)
                Console.WriteLine("Your input {0} is a perfect number.", input);

            else
                Console.WriteLine("Your input {0} is not a perfect number.", input);
        }
    }
}
