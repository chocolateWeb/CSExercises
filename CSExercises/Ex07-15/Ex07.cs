using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex07
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter salary: $"); 
            double salary = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Total income: {0:c}", salary + (0.1 * salary) + (0.03 * salary));
        }
    }
}
