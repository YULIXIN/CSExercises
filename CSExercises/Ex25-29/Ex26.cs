using System;
namespace CSExercises
{
    public class Ex26
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("NO\tINVERSE\tSQUAR ROOT\tSQUARE");
            Console.WriteLine("-------------------------------");
            double i = 1;
            do
            {
                Console.WriteLine("{0}.0\t{1:0.0##}\t{2:0.0##}\t{3:0.0}", i,1/i , Math.Sqrt(i) / 1, i * i);
                i++;
            } while (i < 11);
            
        }
    }
}
