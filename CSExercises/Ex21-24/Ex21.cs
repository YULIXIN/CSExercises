using System;
namespace CSExercises
{
    public class Ex21
    {
        public static void Main(string[] args)
        {
            int i;
            Console.Write("Please enter an integer number:");
            i = Convert.ToInt32(Console.ReadLine());
            while(i!=88)
            {
                Console.WriteLine("Wrong number,please enter again:");
                i = Convert.ToInt32(Console.ReadLine());
            } 
            Console.WriteLine("Lucky you...");
        }
    }
}
