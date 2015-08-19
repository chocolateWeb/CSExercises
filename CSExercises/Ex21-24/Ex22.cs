using System;

namespace CSExercises
{
    public class Ex22
    {
        public static void Main(string[] args)
        {
            int smaller, larger;

            Console.Write("Enter A: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter B: ");
            int b = Convert.ToInt32(Console.ReadLine());


            if(a > b)
            {
                smaller = b;
                larger = a; 
            }
            else
            {
                smaller = a;
                larger = b; 
            }
                
            while(smaller != larger)
            {
                larger = larger - smaller;
            }
            
            Console.WriteLine("HCF: {0}", smaller);
            Console.WriteLine("LCM: {0}", (a*b) / smaller);
        }
    }
}
