using System;

namespace CSExercises
{
    public class Ex19
    {
        public static void Main(string[] args)
        {
            double cost = 0;

            Console.Write("Distance (km): ");
            double dist = Convert.ToDouble(Console.ReadLine());

            dist = Math.Ceiling(dist * 10) / 10;
            Console.WriteLine("Total cost: {0}", dist);
 
            if (dist > 0)
                cost = cost + 2.4;
            
            if (dist > 0.5)
                cost = cost + (dist - 0.5) * 10 * 0.04;
            
            if (dist > 9)
                cost = cost + (dist - 9) * 10 * 0.05;
            
            Console.WriteLine("Total cost: {0:c}", cost); 
        }
    }
}