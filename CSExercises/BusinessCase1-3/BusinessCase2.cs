using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    class BusinessCase2
    {
        public static void Main(string[] args)
        {
            string newCode = "";

            Console.Write("Enter old code: ");
            string oldCode = Console.ReadLine();

            newCode = oldCode.Substring(2, 2);

            Console.Write("Enter block number: ");
            string block = Console.ReadLine();

            if (block.Length > 3)
            {
                if (block.Substring(3, 1).Equals("A"))
                    newCode = newCode + "1";
                else if (block.Substring(3, 1).Equals("B"))
                    newCode = newCode + "2";
                else if (block.Substring(3, 1).Equals("C"))
                    newCode = newCode + "3";
                else if (block.Substring(3, 1).Equals("D"))
                    newCode = newCode + "4";
                else if (block.Substring(3, 1).Equals("E"))
                    newCode = newCode + "5";
                else if (block.Substring(3, 1).Equals("F"))
                    newCode = newCode + "6";
                else if (block.Substring(3, 1).Equals("G"))
                    newCode = newCode + "7";
                else if (block.Substring(3, 1).Equals("H"))
                    newCode = newCode + "8";
                else { }

                newCode = newCode + block.Substring(0, 3);
            }
            else
                newCode = newCode + "0" + block.Substring(0, 3);

            Console.WriteLine("Your new postal code is: {0}", newCode);
        }
    }
}
