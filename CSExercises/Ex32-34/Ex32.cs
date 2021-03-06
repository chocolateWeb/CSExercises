using System;

namespace CSExercises
{
    public class Ex32
    {
        public static void Main(string[] args)
        {
            int[] sales = new int[12];
            int maxSales = 0, max = 0, minSales = 0, min = 0;
            double total = 0.0;

            for (int i = 0; i < sales.Length; i++)
            {
                Console.Write("Enter sales for month {0}: ", i);
                sales[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < sales.Length; i++)
            {
                total += sales[i];

                if (sales[i] > maxSales)
                {
                    maxSales = sales[i];
                    max = i;
                }
            }
            Console.WriteLine("Maximum Sales: {0}", max);


            for (int i = 0; i < sales.Length; i++)
            {
                if (sales[i] < minSales)
                {
                    minSales = sales[i];
                    min = i;
                }
            }
            Console.WriteLine("Minimum Sales: {0}", min);
            Console.WriteLine("Average Sales: {0}", total/12.0);
        }
    }
}
