using System;

namespace CSExercises
{
    public class Ex31
    {
        public static void Main(string[] args)
        {
            int sum;

            for(int input = 1; input <= 1000; input++)
            {
                sum = 0;

                for (int i = 1; i < input; i++)
                {
                    if (input % i == 0)
                        sum += i;
                }

                if (input == sum)
                    Console.WriteLine("{0}", input);
            }                
        }
    }
}
