using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex06
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please write a number and i will print the squre root of it:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The squre root of it is: {0:0.000}", Math.Sqrt(1.0 * x));
        }
    }
}
