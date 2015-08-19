using System;

namespace CSExercises
{
    public class Ex15
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int input = Convert.ToInt32(Console.ReadLine());

            int num = input;            
            int armstrong = 0, remainder;

            if(input >= 100 && input <= 999)
            {
                while(num != 0)
                {
                    remainder = num % 10;

                    armstrong = armstrong + (int)Math.Pow(remainder,3);

                    num = num / 10;
                }
                
                if(input == armstrong)
                    Console.WriteLine("Your input is an Armstrong number.");
                else
                    Console.WriteLine("Your input is not an Armstrong number.");
            }
            else
                Console.WriteLine("Your input is not an Armstrong number.");
        }
    }
}