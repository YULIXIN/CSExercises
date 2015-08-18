using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex16
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name:");
            String A = Console.ReadLine();
            Console.WriteLine("Please enter your gender(M / F):");
            String B = Console.ReadLine();
            
            if (B == "M") 
            Console.WriteLine("Good Morning Mr." + A);
            else if(B == "F")
                Console.WriteLine("Good Morning Ms." + A);
            else if(B!= "F" && B!="M" )
                Console.WriteLine("You typed the wrong information");
        }
    }
}