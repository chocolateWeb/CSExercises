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
            Console.Write("Distance: ");
            double dist = Convert.ToInt32(Console.ReadLine());

            Console.Write("Total fare: {0:.00}", Math.Round((2.4 + (3.24 * 0.4)),2));
        }
    }
}
