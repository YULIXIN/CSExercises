using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex05
    {
        public static void Main(string[] args)
        {   
            Console.WriteLine("Please write a number and i will print the squre root of it:");
            Double x = Convert.ToDouble(Console.ReadLine());
            x = Math.Sqrt(x);
            Console.WriteLine("The squre root of it is: {0:0.000}" , x);
        }
    }
}
