using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex05
    {
        public static void Main(string[] args)
        {
            Console.Write("Double Input: ");
            double num = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Square Root of {0}: {1:.###}", num, Math.Sqrt(num));   
        }
    }
}
