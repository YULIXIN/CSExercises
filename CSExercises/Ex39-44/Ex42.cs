namespace CSExercises
{
    public class Ex42
    {
        public static int FindWord(string s1, string s2)
        {
            
            int i,s;
            string a;
            int b = 0;
            s = s1.Length;
            for (i = 0; i < s - s2.Length; i++)
            {
                a = s1.Substring(i, s2.Length);
                b= a.CompareTo(s2);
            }
            if (b != 0)
                return i;
            else
                return 0;
        }
    }
}
