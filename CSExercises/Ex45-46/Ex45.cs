using System;
namespace CSExercises
{
    public class Ex45
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter an number in 2 decimals:\t");
            double x = Convert.ToDouble(Console.ReadLine());
            int y =Convert.ToInt32(Math.Round(x * 100));
            int i,a, b, c, d, e;
            a = y / 100;
            for(i=0;i<a;i++)
            {
                Console.WriteLine("100c");
            }
            b = (y - 100 * a) / 50;
            for(i=0;i<b;i++)
            {
                Console.WriteLine("50c");
            }
            c = (y % 50) / 20;
            for(i=0;i<c;i++)
            {
                Console.WriteLine("20c");
            }
            d = (y % 20) / 10;
            for (i = 0; i < d; i++)
            {
                Console.WriteLine("10c");
            }
            e = (y % 10) / 5;
            for (i = 0; i < e; i++)
            {
                Console.WriteLine("5c");
            }
        }
    }
}
