using System;
namespace CSExercises
{
    public class Ex35
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter a phrase:");
            int j, counter, counter1, counter2, counter3, counter4,counter5;
            counter = 0; counter1 = 0; counter2 = 0;counter3=0;counter4 = 0;counter5 = 0;
           string[]s = new string[]{ Console.ReadLine() };
            for (j = 0; j < s.Length; j++)
            {
                string A = s[j].Substring( j, 1);
                //Pay sttention to the s[i];
                if(A=="a")
                {
                    counter1++;
                }
                else if(A=="e")
                    {
                    counter2++;
                }
                else if(A=="i")
                {
                    counter3++;
                }
                else if(A=="o")
                {
                    counter4++;
                }
                else  if (A == "u")
                {
                    counter5++;
                }
                else if ( (A != "a")&& (A != "i") && (A != "O") &&(A != "u"))
                {
                    counter++;
                }
               
            }
            Console.WriteLine("Number of a:{0}",counter1);
            Console.WriteLine("Number of e:{0}", counter2);
            Console.WriteLine("Number of i:{0}", counter3);
            Console.WriteLine("Number of o:{0}", counter4);
            Console.WriteLine("Number of u:{0}", counter5);
            Console.WriteLine("The counter of the match number is: {0}",s.Length- counter);
        }
    }
}