using System;
namespace CSExercises
{
    public class Ex37
    {
        public static void Main(string[] args)
        {
            string a = "institute of systems science";
            string[] b = a.Split('\t');
            int i;
            for (i = 0; i < b.Length-1; i++)
            {
                string r = " ";
                string s;
                if (b.Length > 1)
                {
                    s = b[i].Substring(0, 1).ToUpper() + b[i].Substring(1, b.Length - 1);
                    s = s + r;
                    Console.Write("{0}", s);
                }
            }
        }
    }
}
