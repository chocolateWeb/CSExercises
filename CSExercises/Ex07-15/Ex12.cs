using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex12
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter distance: ");
            double dist = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Total fare: {0:c2}", Math.Round((10 * (2.4 + (dist * 0.4)))) / 10);
        }
    }
}
