using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex12
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter the distance you have travelled:");
            Double x = Convert.ToDouble(Console.ReadLine());
            Double y;
            y=2.4 + 0.4 * x;
            y = Math.Round(y, 1);
            Console.WriteLine("Your total fare is: ${0:0.00} ",y);
        }
    }
}
