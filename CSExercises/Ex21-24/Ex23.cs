using System;

namespace CSExercises
{
    public class Ex23
    {
        public static void Main(string[] args)
        {
            int count = 0, input = 0;

            Random r = new Random();
            int num = r.Next(0, 10);

            do
            {
                if(count > 1)
                    Console.WriteLine("Try Again");

                Console.Write("Enter a number (0-9): ");
                input = Convert.ToInt32(Console.ReadLine());
                count++;

            } while (input != num);
            
            Console.WriteLine("Congratulations. You took {0} attempts to make the guess.", count);           
            
            if(count > 0 && count < 3)
                Console.WriteLine("You are a Wizard!");

            else if(count > 2 && count < 6)
                Console.WriteLine("You are a good guess!");

            else
                Console.WriteLine("You are lousy!");
        }
    }
}
