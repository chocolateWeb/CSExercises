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
            double centigrade;
            centigrade = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("{0}", 1.8 * centigrade + 32);
        }
    }
}
