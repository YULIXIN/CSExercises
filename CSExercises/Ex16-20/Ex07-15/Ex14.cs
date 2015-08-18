using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSExercises
{
    public class Ex14
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Dear, you need to enter the 3 sides of the triangle by the turn a,b,c:");
            double a = System.Convert.ToDouble(Console.ReadLine());
            double b = System.Convert.ToDouble(Console.ReadLine());
            double c = System.Convert.ToDouble(Console.ReadLine());
            double s = (a + b + c) / 2;
            System.Console.WriteLine("The area of the triangle is:{0}",Math.Sqrt(s));

        }
    }
}