using System;
namespace CSExercises
{
    public class Ex46
    {
        public static void Main(string[] args)
        {
            int[] a = new int[50];
            int[] b = new int[] { 1,2,3,4,5,6,7,8,9};
            Console.WriteLine("Number\tcount");
            Random r = new Random();
            int i,j;
            int[]c=new int[]{0,0,0,0,0,0,0,0,0};
            for (i = 0; i < 50; i++)
            {
                a[i] = r.Next(0, 10);
                for (j = 0; j < 10; j++)
                {
                    if (b[i] == j)
                    {
                        c[j] = c[j] + 1;
                    }
                }
            }
            int x;
            for (x = 0; x < 10; x++)
            {
                Console.WriteLine("{0}\t{1}", b[x], c[x]);
            }          
        }
    }
}
