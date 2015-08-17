using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex10
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Dear, you need to enter two points (x1,y1) and (x2,y2) by the turn x1,y1,x2,y2:");
            Double x1, y1, x2, y2,z1,z2,z3;
            x1 = Convert.ToDouble(Console.ReadLine());
            y1 = Convert.ToDouble(Console.ReadLine());
            x2 = Convert.ToDouble(Console.ReadLine());
            y2 = Convert.ToDouble(Console.ReadLine());
            z1 = x2 - x1;
            z2 = y2 - y1;
            z3 = z1 * z1 + z2 * z2;
            Console.WriteLine("The distance between the two points is:{0}",Math.Sqrt(z3));

        }
    }
}
