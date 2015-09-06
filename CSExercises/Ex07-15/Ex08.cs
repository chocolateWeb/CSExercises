using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex08
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter centigrade: ");
            double centigrade = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Fahrenheit: {0}", 1.8 * centigrade + 32);
        }
    }
}
