using System;

namespace CSExercises
{
    public class Ex46
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            int[] randomNum = new int[50];

            for (int i = 0; i < 50; i++)
            {
                Random r = new Random();
                randomNum[i] = r.Next(0, 10);

                switch (randomNum[i])
                {
                    case 0:
                        arr[0] += 1; break;
                    case 1:
                        arr[1] += 1; break;
                    case 2:
                        arr[2] += 1; break;
                    case 3:
                        arr[3] += 1; break;
                    case 4:
                        arr[4] += 1; break;
                    case 5:
                        arr[5] += 1; break;
                    case 6:
                        arr[6] += 1; break;
                    case 7:
                        arr[7] += 1; break;
                    case 8:
                        arr[8] += 1; break;
                    case 9:
                        arr[9] += 1; break;
                    default:
                        break;
                }
            }

            Console.WriteLine("Number\tCount");
            

            for (int i = 0; i < arr.Length; i++)
            {                
                Console.WriteLine("   {0}\t  {1}", i, arr[i]);
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Number");
            for (int i = 0; i < arr.Length; i++)
            {                
                Console.Write("   {0}  ", i);
                for(int j = 0; j < arr[i]; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }            
        }
    }
}
