using System;

namespace CSExercises
{
    public class Ex19
    {
        public static void Main(string[] args)
        {
            double cost = 0;

            Console.Write("Enter distance (km): ");
            double dist = Convert.ToDouble(Console.ReadLine());

            dist = Math.Ceiling(dist * 10) / 10;
 
            if (dist > 0)
                cost += 2.4;
            
            if (dist > 0.5 && dist < 9)
                cost += (dist - 0.5) * 10 * 0.04;

            if (dist > 0.5 && dist >= 9)
                cost += 8.5 * 10 * 0.04;
            
            if (dist >= 9)
                cost += (dist - 9) * 10 * 0.05;
            
            Console.WriteLine("Total cost: {0:c}", cost); 
        }
    }
}