using System;

namespace CSExercises
{
    public class Ex45
    {
        public static void Main(string[] args)
        {            
            int oneDollarCoins = 0, fiftyCentCoins = 0, twentyCentCoins = 0, fiveCentCoins = 0;                        

            Console.Write("Enter input amount: ");
            double amt = Convert.ToDouble(Console.ReadLine());

            if(amt >= 0.05 && amt <= 3.50)
            {
                amt = Math.Round(amt / 0.05) * 0.05;

                if(amt / 1.0 != 0.0)
                {                    
                    oneDollarCoins = (int)(Math.Floor(amt / 1.0)); 
                    amt = amt % 1.0; 

                    for (int i = 0; i < oneDollarCoins; i++)
                    {
                        Console.WriteLine("100c");
                    }
                }

                if(amt / 0.5 != 0.0)
                {
                    fiftyCentCoins = (int)(Math.Floor(amt / 0.5));
                    amt = amt % 0.5;

                    for (int i = 0; i < fiftyCentCoins; i++)
                    {
                        Console.WriteLine("50c");
                    }
                }

                if (amt / 0.2 != 0.0)
                {
                    twentyCentCoins = (int)(Math.Floor(amt / 0.2));
                    amt = amt % 0.2;

                    for (int i = 0; i < twentyCentCoins; i++)
                    {
                        Console.WriteLine("20c");
                    }
                }

                if (amt / 0.05 != 0.0)
                {
                    fiveCentCoins = (int)(Math.Floor(amt / 0.05));
                    amt = amt % 0.05;

                    for (int i = 0; i < fiveCentCoins; i++)
                    {
                        Console.WriteLine("5c");
                    }
                }
            }
        }
    }
}
