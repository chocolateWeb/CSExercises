using System;

using System.Data.SqlClient;

namespace CSExercises
{
    public class Ex40
    {
        public static void Main(string[] args)
        {
            for(int i = 1; i <= 25; i++)
            {
                Console.WriteLine("Squareroot of {0}: {1}", i, SQT(i));
            }
        }

        public static double SQT(int y)
        {            
            Random r = new Random();
            double G = r.Next(1, y + 1);

            while (G * G != y)
            {
                double num = G;
                G = Math.Round((G + (y / G)) / 2, 5);

                if (num == G)
                    break;
            }

            return G;
        }
    }
}
