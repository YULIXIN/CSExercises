using System;
using System.Data.SqlClient;

namespace CSExercises
{
    public class Ex40
    {
        public static void Main(string[] args)
        {
            int i;
            for (i=1; i<=25;i++)
            {
                Console.WriteLine(i + '\t' + SQT(i)+'\n');
            }
        }

        public static double SQT(int y)
        {
            double j;
            j = Math.Round(Math.Sqrt(y),2);
            return j;
        }
    }
}
