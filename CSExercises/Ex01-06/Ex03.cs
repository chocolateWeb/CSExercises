using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex03
    {
        public static void Main(string[] args)
        {
            Console.Write("Double: ");
            double num = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Square of {0}: {1}", num, num * num);
        }
    }
}
