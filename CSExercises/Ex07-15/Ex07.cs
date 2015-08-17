using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex07
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter your salary :$");
            Double x = Convert.ToDouble(Console.ReadLine());
            Double y;
            y = 1.13 * x;
            Console.WriteLine("Your total income is:${0}", y);
                 
        }
    }
}