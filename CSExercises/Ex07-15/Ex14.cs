using System;

namespace CSExercises
{
    public class Ex14
    {
        public static void Main(string[] args)
        {
            Console.Write("Length of a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Length of b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Length of c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            double s = (a + b + c) / 2;

            if ((s > 0) && (a > 0) && (b > 0) && (c > 0))
            {
                Console.WriteLine("Area of triangle: {0}", Math.Sqrt(s * (s - a) * (s - b) * (s - c)));
            }            
        }
    }
}