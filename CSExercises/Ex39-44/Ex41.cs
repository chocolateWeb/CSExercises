using System;

namespace CSExercises
{
    public class Ex41
    {
        public static void main(string[] args)
        {
            Console.WriteLine(InString("The quick brown fox jumps over the lazy dog", "dog"));
        }
        
        public static bool InString(string s1, string s2)
        {
            if (s1.Contains(s2))
                return true;

            else
                return false;
        }
    }
}
