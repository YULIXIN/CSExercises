using System;
namespace CSExercises
{
    public class Ex30
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("The prime number between 5 to 10000: ");
            int i, j,a;
           
            for (i = 5; i <= 10000; i++)
            {
                a = 0;
                for (j = 2; j < i; j++)
                {
                    if (i % j == 0)
                        a++;

                }
                if (a == 0)
                {
                    Console.Write("{0}\t", i);
                }
            }
        }
    }
}

