using System;
namespace CSExercises
{
    public class Ex27
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("X\tY");
            Console.WriteLine("----------------");
            int x = -5;
            int i,j;
            i = 0;
            do
            {
                Console.WriteLine("{0:0.0}\t{1:0.0}", x, 2 * x * x - 4 * x + 3);
                x++;
            } while (x < 5);
            Console.WriteLine("The below star indicate when x flow from 1 to 20 the value of y:");
            for (i=1; i < 21;i++)
            {
                int y;
                y = 2 * i * i - 4 * i + 3;
                for(j=1;j<y+1;j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine('\n');
            }
        }
    }
}
