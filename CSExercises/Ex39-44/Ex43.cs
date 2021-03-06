using System;

namespace CSExercises
{
    public class Ex43
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Hex(196));
        }

        public static string Hex(int i)
        {
            int remainder = 0;
            string hexValue = "";

            while(i % 16 != 0)
            {
                remainder = i % 16;

                switch (remainder)
                {
                    case 10:
                        hexValue = "A" + hexValue; break;

                    case 11:
                        hexValue = "B" + hexValue; break;

                    case 12:
                        hexValue = "C" + hexValue; break;

                    case 13:
                        hexValue = "D" + hexValue; break;

                    case 14:
                        hexValue = "E" + hexValue; break;

                    case 15:
                        hexValue = "F" + hexValue; break;

                    default:
                        hexValue = Convert.ToString(remainder) + hexValue; break;
                }

                i /= 16; 

            }

            return hexValue;
        }
    }
}
