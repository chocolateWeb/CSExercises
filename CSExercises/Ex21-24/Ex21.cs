using System;

namespace CSExercises
{
    public class Ex21
    {
        public static void Main(string[] args)
        {
            int input = 0;
            
            while(input != 88)
            {
                Console.Write("Enter integer number: ");
                input = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Lucky you... ");
        }
    }
}
