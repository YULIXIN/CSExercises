using System;
namespace CSExercises
{
    public class Ex19
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please show your distance by enter the kilometer you have gone:");
            double X = Convert.ToDouble(Console.ReadLine());
            if (X > 0 && X <= 0.5)
            {
                Console.WriteLine("Your cost is $2.40");
            }
            else if (X > 0.5 && X <= 9)
            {
                Console.WriteLine("Your cost is $ {0:0.00}", 0.4 * (X - 0.5)+2.4);
            }
            else if (X > 9)
            {
                Console.WriteLine("Your cost is $ {0:0.00}", 0.05 * (X - 9) + 5.8);
            }
            else if (X <= 0)
            {
                Console.WriteLine("Error");
            }
        }
    }
}