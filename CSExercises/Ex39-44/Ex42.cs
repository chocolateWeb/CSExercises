using System;

namespace CSExercises
{
    public class Ex42
    {
        public static void Main(string[] args)
        {
            string s = "The quick brown fox jumps over the lazy dog", sub = "dog";

            int pos = FindWord(s, sub);

            if (pos != -1)
                Console.WriteLine("The string \"{0}\" occurs in \"{1}\" at position {2}", sub, s, pos);
        }

        public static int FindWord(string s1, string s2)
        {
            int containsWordPos = -1;

            if (s1.Length >= s2.Length)
            {
                for (int i = 0; i <= s1.Length - s2.Length; i++)
                {
                    if (s1.Substring(i, s2.Length).Equals(s2))
                        containsWordPos = i;
                }
            }

            else
            {
                for (int i = 0; i <= s2.Length - s1.Length; i++)
                {
                    if (s2.Substring(i, s1.Length).Equals(s1))
                        containsWordPos = i;
                }
            }

            return containsWordPos;
        }
    }
}
