using System;

namespace CSExercises
{
    public class Ex18
    {
        public static void Main(string[] args)
        {
            Console.Write("Grade: ");
            int marks = Convert.ToInt32(Console.ReadLine());

            
            if (marks >= 80 && marks <= 100)
                Console.WriteLine("You scored {0} marks which is A grade.", marks);

            else if (marks >= 60 && marks <= 79)
                Console.WriteLine("You scored {0} marks which is B grade.", marks);

            else if (marks >= 40 && marks <= 59)
                Console.WriteLine("You scored {0} marks which is C grade.", marks);

            else if (marks >= 0 && marks <= 39)
                Console.WriteLine("You scored {0} marks which is F grade.", marks);

            else if (marks < 0 || marks > 100)
                Console.WriteLine("*Error**");

            else
                Console.WriteLine("*Error**");
        }
    }
}