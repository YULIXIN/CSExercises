using System;
namespace CSExercises
{
    public class Ex39
    {
        public static long Factorial(long n)
        { 
            Console.WriteLine("Please enter a number:");
            int x = Convert.ToInt32(Console.ReadLine());
            int i;
            for(i=1;i< x;i++)
            {
                x *= i;
            }
            return x;
        }
    }
}
