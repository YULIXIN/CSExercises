using System;
namespace CSExercises
{
    public class Ex28
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            int num = Convert.ToInt32(Console.ReadLine());
            int i;
            for (i = 2; i < num; i++)
            {
                if(num%i==0)
                {
                    Console.WriteLine("Not Prime");
                }
            }
            Console.WriteLine("Prime");
        }
    }
}
