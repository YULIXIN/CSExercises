using System;
namespace CSExercises
{
    public class Ex43
    {
        public static string Hex(int i)
        {
            int  Sum=0 ;
            int j = 0;
            while (i >= 1)
            {

                Sum = Sum + (i % 2) * (int)(Math.Pow(10, j));
                j++;
                i = i / 2;

            }
            string s = Convert.ToString(Sum);
            return s;
        }
    }
}
