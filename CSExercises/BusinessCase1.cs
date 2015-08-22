using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    class BusinessCase1
    {
        public static void Main(string[] args)
        {
            string[] tenToNinety = new string[10] { "", "Ten", "Twenty", "Thirty", "Fourty", "Fifty", "Sixty", "Seventy", "Eight", "Nine" };

            string[] oneToNineteen = new string[20] {"", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine",
                "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };

            string output;
            int dollar;

            Console.Write("Enter input amount: ");
            string amt = Console.ReadLine();

            if (Convert.ToDouble(amt) < 10000.00)
            {
                output = "Dollar ";
                string[] amtArr = amt.Split('.');

                switch (amtArr[0].Length)
                {
                    case 0:
                        break;

                    case 1:
                        output = output + oneToNineteen[Convert.ToInt32(amtArr[0])] + " ";
                        break;

                    case 2:
                        dollar = Convert.ToInt32(amtArr[0]);

                        if (dollar < 19)
                            output = output + oneToNineteen[Convert.ToInt32(amtArr[0])] + " ";
                        else
                        {
                            output = output + tenToNinety[Convert.ToInt32(amtArr[0].Substring(0, 1))] + " ";
                            output = output + oneToNineteen[Convert.ToInt32(amtArr[0].Substring(1, 1))];
                        }
                        break;

                    case 3:
                        output = output + oneToNineteen[Convert.ToInt32(amtArr[0].Substring(0, 1))] + " Hundred And ";

                        dollar = Convert.ToInt32(amtArr[0].Substring(1, 2));

                        if (dollar < 19)
                            output = output + oneToNineteen[Convert.ToInt32(amtArr[0].Substring(1, 2))];
                        else
                        {
                            output = output + tenToNinety[Convert.ToInt32(amtArr[0].Substring(1, 1))] + " ";
                            output = output + oneToNineteen[Convert.ToInt32(amtArr[0].Substring(2, 1))];
                        }
                        break;

                    case 4:
                        output = output + oneToNineteen[Convert.ToInt32(amtArr[0].Substring(0, 1))] + " Thousand ";

                        output = output + oneToNineteen[Convert.ToInt32(amtArr[0].Substring(1, 1))] + " Hundred And ";

                        dollar = Convert.ToInt32(amtArr[0].Substring(1, 2));

                        if (dollar < 19)
                            output = output + oneToNineteen[Convert.ToInt32(amtArr[0].Substring(2, 2))];
                        else
                        {
                            output = output + tenToNinety[Convert.ToInt32(amtArr[0].Substring(2, 1))] + " ";
                            output = output + oneToNineteen[Convert.ToInt32(amtArr[0].Substring(3, 1))];
                        }
                        break;

                    default:
                        break;
                }

                output = output + " Cents ";

                switch (amtArr[1].Length)
                {
                    case 0:
                        break;

                    case 1:
                        output = output + oneToNineteen[Convert.ToInt32(amtArr[1])];
                        break;

                    case 2:
                        int cents = Convert.ToInt32(amtArr[1]);

                        if (cents < 19)
                            output = output + oneToNineteen[Convert.ToInt32(amtArr[1])];
                        else
                        {
                            output = output + tenToNinety[Convert.ToInt32(amtArr[1].Substring(0, 1))] + " ";
                            output = output + oneToNineteen[Convert.ToInt32(amtArr[1].Substring(1, 1))];
                        }
                        break;

                    default:
                        break;
                }

                Console.WriteLine(output);
            }
        }
    }
}
