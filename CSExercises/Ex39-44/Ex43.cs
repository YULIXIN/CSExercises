using System;
namespace CSExercises
{
    public class Ex43
    {
        public static void Main(string[] args)
        {
            int j;
        for(j=0;j<=100;j++)
        {
            string x = Hex(j);
            Console.WriteLine(x + "\t");
        }
        }
        public static string Hex(int i)
        {
      char[]a=new char[]{'1','2','3','4','5','6','7','8','9','A','B','C','D','E','F'};
            int s=i/16;
            string t="s\ta[i-16*s}";
            return t;
        }
          
            
        }
    }

