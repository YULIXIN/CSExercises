using System;
namespace CSExercises
{
    public class Ex38
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Name\tMark\n");
            string[] name = new string[]{ "John", "Venkat", "Mary", "Victor", "Betty" };
            int[] mark = new int[] { 63, 29, 75, 82, 55 };
            Console.WriteLine( "Name\tMark");
            int temp1;
            string temp2;
            int a,b,i;
            for(a=0;a<name.Length-1;a++)
            {
                for(b=a+1;b<name.Length;b++)
                    if(mark[a]<mark[b])
                    {
                        temp1 = mark[a];
                        mark[a] = mark[b];
                        mark[b] = temp1;
                        temp2 = name[a];
                        name[a] = name[b];
                        name[b] = temp2;
                    }
            }
            for(i=0;i<mark.Length;i++)
            {
                Console.WriteLine("{0}\t{1}", name[i], mark[i]);
            }
            for (a = 0; a < name.Length - 1; a++)
            {
                for (b = a + 1; b < name.Length; b++)
                    if (name[a].CompareTo(name[b])==1)
                    { 
                        temp2 = name[a];
                        name[a] = name[b];
                        name[b] = temp2;
                        temp1 = mark[a];
                        mark[a] = mark[b];
                        mark[b] = temp1;
                    }
            }
            for (i = 0; i < mark.Length; i++)
            {
                Console.WriteLine("{0}\t{1}", name[i], mark[i]);
            }
        }
        }
    }

