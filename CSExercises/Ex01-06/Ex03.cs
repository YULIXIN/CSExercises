using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex03
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number and i will print the square of it:");
            Double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The square is:" + x * x);
            
        }
    }
}
