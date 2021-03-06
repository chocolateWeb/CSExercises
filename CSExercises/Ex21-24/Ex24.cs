using System;

namespace CSExercises
{
    public class Ex24
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter input (N): ");
            int N = Convert.ToInt32(Console.ReadLine());

            Random r = new Random();
            double G = r.Next(1, N+1);
            
            while(G * G != N)
            {
                double num = G;
                G = Math.Round((G + (N / G)) / 2, 5);
                
                if (num == G)
                    break;
            }

            Console.WriteLine("Square root of {0}: {1:.00000}", N, G);
        }
    }
}
