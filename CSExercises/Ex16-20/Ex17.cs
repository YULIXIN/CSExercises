                                                                                                                                                                                                                                                          using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex17
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name:");
            String A = Console.ReadLine();
            Console.WriteLine("Please enter your gender(M / F):");
            String B = Console.ReadLine();
            Console.WriteLine("Please enter your age:");
            Int32 C;
            C=Convert.ToInt16( Console.ReadLine());
            if(B=="M")
            {
                if (C >= 40)
                {
                    Console.WriteLine("Good Morning Uncle " + A);
                }
                else if (C > 0 && C < 40) ;
                Console.WriteLine("Good Morning Mr." + A);
            }
            else if(B=="F")
             {
                 if (C >= 40)
                 {
                     Console.WriteLine("Good Morning Aunty " + A);
                 }
                 else if (C > 0 && C < 40) ;
                Console.WriteLine("Good Morning Ms." + A);
            }
            else if(B!="M"&&B!="F")
                Console.WriteLine("You have typed the wrong information");
        }
    }
}