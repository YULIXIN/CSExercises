using System;
namespace CSExercises
{
    public class Ex24
    {
        public static void Main(string[] args)
        {
                Random ran = new Random();
                Console.WriteLine("Enter a integer:");
                int N = Convert.ToInt32(Console.ReadLine());
                int S = ran.Next(1, N + 1);
                double G = S;
                if (G * G == N)
                        Console.WriteLine("The squre root of the given number N is:{0}", G);
                    else
                    { 
                            while (Math.Abs(N - G * G) > 0.00001)
                            {
                                G = (G + (N / G)) / 2;
                            }
                        Console.WriteLine("The squre root of the given number N is:{0}", G);
                }
        }
    }
}
