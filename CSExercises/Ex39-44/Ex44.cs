using System;

namespace CSExercises
{
    public class Ex44
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Substitute("hello world", 'e', 'a'));
        }

        public static string Substitute(string s, char c1, char c2)
        {
            string newString = "";

            for(int i = 0; i < s.Length; i++)
            {                
                if (s.Substring(i,1).Equals(c1.ToString()))
                {
                    if (i == 0)
                        newString = c2.ToString() + s.Substring(1, s.Length - 1);

                    else if (i == s.Length - 1)
                        newString = s.Substring(0, s.Length - 2) + c2.ToString();
                    else
                        newString = s.Substring(0, i) + c2.ToString() + s.Substring(i + 1, s.Length - 1 - i);
                }
            }

            return newString;
        }
    }
}
