using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    class BusinessCase3
    {
        public static void Main(string[] args)
        {
            Encrypt("SeazAme94");
        }

        public static void Encrypt(string s)
        {
            byte[] asciiBytes = Encoding.ASCII.GetBytes(s);

            s = "";

            for (int i = 0; i < asciiBytes.Length; i++)
            {
                if (asciiBytes[i] == 90)
                    asciiBytes[i] = 65;
                else if (asciiBytes[i] == 122)
                    asciiBytes[i] = 97;
                else if (asciiBytes[i] == 57)
                    asciiBytes[i] = 48;
                else
                    asciiBytes[i] += 1;
            }

            s = Encoding.ASCII.GetString(asciiBytes);
            Console.WriteLine("First Transformation: {0}", s);

            if(s.Length % 2 == 0)
            {
                string s1 = s.Substring(0, s.Length / 2);
                string s2 = s.Substring(s.Length / 2, s.Length / 2);
                string output1 = "", output2 = "";

                for (int i = s1.Length - 1; i >= 0; i--)
                {                   
                    output1 = output1 + s1.Substring(i, 1);
                    output2 = output2 + s2.Substring(i, 1);
                }
                s = output2 + output1;                
            }

            else
            {
                string s1 = s.Substring(0, s.Length / 2);
                string s2 = s.Substring((s.Length / 2) + 1, s.Length / 2);
                string s3 = s.Substring(s.Length / 2, 1);

                string output1 = "", output2 = "";

                for (int i = s1.Length - 1; i >= 0; i--)
                {
                    output1 = output1 + s1.Substring(i, 1);
                    output2 = output2 + s2.Substring(i, 1);
                }
                s = output2 + s3 + output1;

            }
            Console.WriteLine("Second Transformation: {0}", s);
        }
    }
}
