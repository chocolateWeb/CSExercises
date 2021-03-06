using System;

namespace CSExercises
{
    public class Ex33
    {
        public static void Main(string[] args)
        {
            int[] num = new int[] {86, 35, 41, 49, 59, 51, 11, 71, 50, 75, 25, 58, 40, 14, 44, 3, 63, 81, 93, 79};
            
            int min, pos, buffer;

            for (int j = 0; j < num.Length; j++)
            {
                min = num[j];
                pos = j;            

                for (int i = j + 1; i < num.Length; i++)
                {
                    if (num[i] < min)
                    {                        
                        min = num[i];
                        pos = i;
                    }
                }

                buffer = num[pos];
                num[pos] = num[j];
                num[j] = buffer;
            }

            for (int k = 0; k < num.Length; k++)
            {
                Console.Write("{0} ", num[k]);
            }

            Console.WriteLine();
        }
    }
}
