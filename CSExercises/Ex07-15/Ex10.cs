using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex10
    {
        public static void Main(string[] args)
        {
            int x1 = 0, y1 = 0, x2 = 0, y2 = 0;

            Console.Write("x1: ");
            x1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("y1: ");
            y1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("x2: ");
            x2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("y2: ");
            y2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Distance: {0}", Math.Sqrt((x2 - x1) * (x2 -x1) + (y2 - y1) * (y2 - y1)));
        }
    }
}