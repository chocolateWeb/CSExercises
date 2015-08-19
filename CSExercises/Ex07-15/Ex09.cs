using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex09
    {
        public static void Main(string[] args)
        {
            Console.Write("Value of x: "); 
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Value of y: {0}", (2 * x * x) - (4 * x) + 3);
        }
    }
}
