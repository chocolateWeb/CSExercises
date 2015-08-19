using System;

namespace CSExercises
{
    public class Ex16
    {
        public static void Main(string[] args)
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Gender (m/f): ");
            string gender = Console.ReadLine();

            if(gender.Equals("M") || gender.Equals("m"))
                Console.WriteLine("Good morning Mr. " + name );
            else if (gender.Equals("F") || gender.Equals("f"))
                Console.WriteLine("Good morning Ms. " + name);
            else
                Console.WriteLine("Good morning " + name);
        }
    }
}