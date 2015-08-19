using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex13
    {
        public static void Main(string[] args)
        {
            Console.Write("Distance: ");
            double dist = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Total fare: ${0:.00}", Math.Ceiling((10 * (2.4 + (dist * 0.4)))) / 10);
        }
    }
}
