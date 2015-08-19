using System;
namespace CSExercises
{
    public class Ex17
    {
        public static void Main(string[] args)
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Gender (m/f): ");
            string gender = Console.ReadLine();

            Console.Write("Age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (gender.Equals("M") || gender.Equals("m") && age >= 40)
                Console.WriteLine("Good morning Uncle " + name);

            else if (gender.Equals("M") || gender.Equals("m"))
                Console.WriteLine("Good morning Mr. " + name);

            else if (gender.Equals("F") || gender.Equals("f") && age >= 40)
                Console.WriteLine("Good morning Aunty " + name);

            else if (gender.Equals("F") || gender.Equals("f"))
                Console.WriteLine("Good morning Ms. " + name);

            else
                Console.WriteLine("Good morning " + name);
        }
    }
}