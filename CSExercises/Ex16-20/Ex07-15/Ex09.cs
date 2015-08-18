using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex09
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please input a number:");
            Double x;
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Your result of the formula is: {0}", 2 * x * x - 4 * x + 3);

        }
    }
}
