using System;
namespace CSExercises
{
    public class Ex33
    {
        public static void Main(string[] args)
        {
            int[] num = new int[20] { 86, 35, 41, 49, 89, 51, 11, 71, 50, 75, 25, 58, 40, 14, 44, 3, 63, 81, 93, 79 };
            int i,j,k;
            int tem = num[0];
            for (i = 0; i < num.Length-1; i++)
            {
                for (j = i + 1; j < num.Length; j++)
                {
                    if (num[i] < num[j])
                    {
                        tem = num[j];
                        num[j] = num[i];
                        num[i] = tem;  
                    }
                }
                for (k = 0; k < num.Length; k++)
                {
                    Console.WriteLine("{0}",num[k]);
                }
            }
        }
    }
}
