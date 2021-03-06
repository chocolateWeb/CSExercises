using System;

namespace CSExercises
{
    public class Ex22
    {
        public static void Main(string[] args)
        {
            int smaller, larger;

            Console.Write("Enter A: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter B: ");
            int b = Convert.ToInt32(Console.ReadLine());

            do
            {
                if (a > b)
                {
                    smaller = b;
                    larger = a;
                }
                else
                {
                    smaller = a;
                    larger = b;
                }

                larger -= smaller;
            } while (smaller != larger);
            
            Console.WriteLine("HCF: {0}", smaller);
            Console.WriteLine("LCM: {0}", (a*b) / smaller);
        }
    }
}
