using System;
namespace CSExercises
{
    public class Ex25
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a integer:");
            int N = Convert.ToInt32(Console.ReadLine());
            int factorial=N;
            if (N < 0)
            {
                Console.WriteLine("The negative doesn't have factorial.");
            }
            else if ( N == 0)
            {
                Console.WriteLine("The factorial of the number is:{0}", 1);
            }
            else if (N == 1 )
            {
                Console.WriteLine("The factorial of the number is:{0}", factorial);
            }
            else
            {
                do
                {
                    factorial = factorial * (N - 1);
                    N--;
                } while (N > 1);
                    Console.WriteLine("The factorial of the number is:{0}", factorial);
            }
        }
    }
}
