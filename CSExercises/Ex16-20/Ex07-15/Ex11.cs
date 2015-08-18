using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex11
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter the distance you have travelled:");
            Double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Your total fare is: {0} $",2.4+0.4*x);

        }
    }
}
