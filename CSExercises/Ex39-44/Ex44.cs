using System;
namespace CSExercises
{
    public class Ex44
    {
        public static string Substitute(string s, char c1, char c2)
        {
            int i;
            char b;
            for(i=0;i<s.Length;i++)
            {
                b =Convert.ToChar( s.Substring(i, 1));
                if(b==c1)
                {
                    b = c1;
                    c1 = c2;
                    c2 = b;
                }
            }
            return s;
        }
    }
}
