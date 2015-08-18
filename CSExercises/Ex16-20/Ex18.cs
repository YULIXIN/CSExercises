using System;
namespace CSExercises
{
    public class Ex18
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter your score:");
            int X = Convert.ToInt32(Console.ReadLine());
            if(X>=80 && X<=100)
            { Console.WriteLine("You scored "+X+"marks wchich is A grade."); 
            }
            else if (X>=60 && X<80)
            { Console.WriteLine("You scored" + X + "marks wchich is B grade.");
            }
            else if (X >= 40 && X < 60)
            {
                Console.WriteLine("You scored" + X + "marks wchich is C grade.");
            }
            else if (X >= 0 && X < 40)
            {
                Console.WriteLine("You scored" + X + "marks wchich is F grade.");
            }
            else if (X >100 || X < 80)
            {
                Console.WriteLine("**Error**");
            }
        }
    }
}