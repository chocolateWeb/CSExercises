using System;

namespace CSExercises
{
    public class Ex38
    {
        public static void Main(string[] args)
        {
            string[] name = new string[5] {"John", "Venkat", "Mary", "Victor", "Betty"};
            int[] mark = new int[5]{63, 29, 75, 82, 55};

            int max, pos, bufferMark = 0;
            string bufferName;

            string first;

            for(int i = 0; i < mark.Length; i++)
            {
                max = mark[i];
                pos = i;

                for (int j = i + 1; j < mark.Length; j++)
                {
                    if(mark[j] > max)
                    {
                        max = mark[j];
                        pos = j;
                    }
                }

                bufferMark = mark[pos];
                bufferName = name[pos];

                mark[pos] = mark[i];
                name[pos] = name[i];

                mark[i] = bufferMark;
                name[i] = bufferName;                
            }

            Console.WriteLine("Name\t\tMark");
            Console.WriteLine("====\t\t====");

            for(int i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i] + "\t\t" + mark[i]);
            }

            
            for (int i = 0; i < name.Length; i++)
            {
                first = name[i];
                pos = i;

                for (int j = i + 1; j < mark.Length; j++)
                {
                    if (name[j].CompareTo(first) < 0 )
                    {
                        first = name[j];
                        pos = j;
                    }
                }

                bufferMark = mark[pos];
                bufferName = name[pos];

                mark[pos] = mark[i];
                name[pos] = name[i];

                mark[i] = bufferMark;
                name[i] = bufferName;
            }

            Console.WriteLine("Name\t\tMark");
            Console.WriteLine("====\t\t====");

            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i] + "\t\t" + mark[i]);
            }            
        }
    }
}
