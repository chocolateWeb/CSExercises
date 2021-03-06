using System;

namespace CSExercises
{
    public class Ex36
    {
        public static void Main(string[] args)
        {
            string forward, backward;
            bool isPalindrome = true;

            Console.Write("Please enter a word/phrase: ");
            string s = Console.ReadLine();

            string w = s.ToUpper();

            if(w.Length % 2 == 0)// even length word
            {
                forward = w.Substring(0, w.Length / 2);
                backward = w.Substring(w.Length / 2, w.Length / 2);
            }

            else // odd length word
            {
                forward = w.Substring(0, w.Length / 2);
                backward = w.Substring((w.Length / 2) + 1, (w.Length / 2));                
            }

            for(int i = 0; i < forward.Length; i++)
            {
                for(int j = backward.Length; j > 0; j--)
                {
                    if(!forward.Substring(0,1).Equals(backward.Substring(backward.Length - 1, 1)))
                    {
                        isPalindrome = false;
                        j = 0;
                        i = forward.Length;
                    }
                }
            }

            if(isPalindrome)
                Console.WriteLine("Your word/phrase {0} is a Palindrome.", s);

            else
                Console.WriteLine("Your word/phrase {0} is not a Palindrome.", s);
        }
    }
}
