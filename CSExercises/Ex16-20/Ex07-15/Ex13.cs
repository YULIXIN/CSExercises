using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex13
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter the distance you have travelled:");
            Double x = Convert.ToDouble(Console.ReadLine());
            Double y;
            y = 2.4 + 0.4 * x;
            y = Convert.ToDouble(Math.Ceiling(y));
            Console.WriteLine("Your total fare is: ${0} ", y);
        }
    }
}
