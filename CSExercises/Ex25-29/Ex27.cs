using System;
namespace CSExercises
{
    public class Ex27
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("X\tY");
            Console.WriteLine("----------------");
            int x=-5;
            do
            {
                Console.WriteLine("{0:0.0}\t{1:0.0}", x, 2 * x * x - 4 * x + 3);
                x++;
            } while (x < 5);

        }
    }
}
