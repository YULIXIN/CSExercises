using System;
namespace CSExercises
{
    public class Ex29
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number :");
            int N = Convert.ToInt32(Console.ReadLine());
            int i,sum;
            sum = 0;
            for(i=1;i<N; i++)
            {
                if(N%i==0)
                {
                    sum = sum + i;
                }
            }
            if(sum==N)
            {
                Console.WriteLine("Perfect Number");
            }
            else
            {
                Console.WriteLine("Not Perfect Number");
            }
        }
    }
}
