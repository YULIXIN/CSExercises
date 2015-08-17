using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex08
    {
        public static void Main(string[] args)
        {
            Double x,y;
           
            Console.Write("Please enter a temperature in Centigrade: ");
            x = Convert.ToDouble(Console.ReadLine());
            y = 1.8 * x + 32;
            Console.WriteLine("Your temperature in Fahrenheit is "+y);

        }
    }
}
