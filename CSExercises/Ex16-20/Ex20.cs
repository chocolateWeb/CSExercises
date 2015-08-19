using System;

namespace CSExercises
{
    public class Ex20
    {
        public static void Main(string[] args)
        {
            double total = 0;

            Console.Write("Enter quantity for TV: ");
            int qtyTV = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter quantity for DVD: ");
            int qtyDVD = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter quantity for MP3: ");
            int qtyMP3 = Convert.ToInt32(Console.ReadLine());

            total = (qtyTV * 900) + (qtyDVD * 500);

            if (total > 5000 && total < 10000)
                total = 0.9 * total;

            else if(total > 10000)
                total = 0.85 * total;

            else { }

            total = total + (qtyMP3 * 700);
            
            Console.WriteLine("Total price for this order is {0:c} ", total);            
        }
    }
}