using System;

namespace CSExercises
{
    public class Ex39
    {
        public static double Factorial(double n)
        {
            double output = 0;

            for (int i = 1; i <= n; i++)
            {
                output = output * i;
            }           
            return output;
        }
    }
}
