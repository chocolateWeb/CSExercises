using System;

namespace CSExercises
{
    public class Ex41
    {
        public static void Main(string[] args)
        {
            string s = "The quick brown fox jumps over the lazy dog", sub = "dog";

            if (InString(s, sub))
                Console.WriteLine("The string \"{0}\" occurs in \"{1}\"", sub, s);
            else
                Console.WriteLine("The string \"{0}\" does not occur in \"{1}\"", sub, s);
        }
        
        public static bool InString(string s1, string s2)
        {
            bool containsString = false;

            if(s1.Length >= s2.Length)
            {
                for (int i = 0; i <= s1.Length - s2.Length; i++)
                {
                    if (s1.Substring(i, s2.Length).Equals(s2))
                        containsString = true;
                }
            }
            
            else
            {
                for (int i = 0; i <= s2.Length - s1.Length; i++)
                {
                    if (s2.Substring(i, s1.Length).Equals(s1))
                        containsString = true;
                }
            }

            return containsString;
        }
    }
}
