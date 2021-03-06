using System;

namespace CSExercises
{
    public class Ex37
    {
        public static void Main(string[] args)
        {
            string output = "", titleCase = "";

            Console.Write("Please enter a word/phrase: ");
            string s = Console.ReadLine();                      

            string[] w = s.Split(' ');

            for(int i = 0; i < w.Length; i++)
            {
                if (i != 0)
                    titleCase += " ";

                output += w[i].Substring(0, 1).ToUpper() + w[i].Substring(1, w[i].Length - 1);
                w[i] = output;

                titleCase += output;
                output = "";
               
            }
            Console.WriteLine(titleCase);
        }
    }
}
