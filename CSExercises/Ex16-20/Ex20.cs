using System;
namespace CSExercises
{
    public class Ex20
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter quantity for TV");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter quantity for DVD");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter quantity for MP3");
            int c = Convert.ToInt32(Console.ReadLine());
            int Y;
            Y = 900 * a + 500 * b + 700 * c;
            if (Y < 5000)
            {
                Console.WriteLine("Total price for this order is :$" + Y);
            }
            else if (Y >= 5000 && Y < 10000)
            {
                if (c == 0)
                {
                    Console.WriteLine("Total price for this order is :$" + 0.9 * Y);
                }
                else
                {
                    Console.WriteLine("Total price for this order is :$" + Y);
                }
            }
            else if (Y >= 10000)
            {
                if (c == 0)
                {
                    Console.WriteLine("Total price for this order is :$" + 0.85 * Y);
                }
                else
                {
                    Console.WriteLine("Total price for this order is :$" + Y);
                }
            }
        }
    }
}