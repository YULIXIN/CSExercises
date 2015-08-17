using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex02
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter number, i will show you square of that number");
            Int32 x=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The square of that number is:"+x * x);
        }
    }
}
