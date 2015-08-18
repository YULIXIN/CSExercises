using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex15
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a 3-digit integer:");
            int w, a, b, c;
            w = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(w);
            a = w / 100;
            b = (w % 100) / 10;
            c = w%10;
            int result = (a * a * a) + (b * b * b) + (c * c * c);
            if (w == result) 
            {
                Console.WriteLine("Your number is an Armstrong number.");
            }
            else if(w != result)
            {
                Console.WriteLine("Your number is not an Armstrong number.");
            }
        }
    }
}