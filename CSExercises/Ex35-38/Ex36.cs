using System;
namespace CSExercises
{
    public class Ex36
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string");
            string s = Console.ReadLine();
            int i, c;
            c = 0;
            for (i = 0; i < s.Length/2; i++)
            {
                if (s.Substring(i, 1) == s.Substring(s.Length-1 - i, 1))
                { c++; }
                else
                    break;
            }
            if (c== s.Length / 2)
            { Console.WriteLine("Palindrome"); }
            else
            {
                Console.WriteLine("Not Palindrome");
            }
            }
        }
}


