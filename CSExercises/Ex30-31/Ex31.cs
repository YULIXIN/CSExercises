using System;
namespace CSExercises
{
    public class Ex31
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("The perfect number between 1 to 1000: ");
            int i, j,sum;
            for(i=1;i<=1000;i++)
            {
                sum = 0;
                for (j = 1; j < i; j++) 
                {
                    if(i%j==0)
                    {
                        sum = sum + j;
                    }
                }
                if(sum==i)
                {
                    Console.Write("{0}\t", i);
                }
            }
        }
    }
}
