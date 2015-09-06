using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex02
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter an integer number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Square of {0}: {1}", num,  num*num);
        }
    }
}
