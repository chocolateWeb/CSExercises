using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex06
    {
        public static void Main(string[] args)
        {            
            Console.Write("Integer Input: ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Square Root of {0}: {1}", num, Math.Sqrt(num));  
        }
    }
}
