using System;
namespace CSExercises
{
    public class Ex34
    {
        public static void Main(string[] args)
        {
            int[,] score = new int[,] {{56,84,68,29}, {94,73,31,89}, {41,63,36,90} , {99,9,18,17}, {62,3,65,75}, {40,96,53,23}, {81,15,27,30}, {21,70,100,22}, {88,50,13,12}, { 48,54,52,78}, {64,71,67,25}, {16,93,46,72} };
            int i, j;
            int sum = 0;
            int Avg;
            for (i = 0; i <score.GetLength(0); i++)
            {
                for(j=0;j <score.GetLength(1);j++)
                {
                    sum = sum + score[i, j];
                }
            }          
            Avg = sum / score.Length;
            Console.WriteLine("The average of all the scores is : {0}", Avg);
        }
    }
}