using System;
namespace CSExercises
{
    public class Ex32
    {
        public static void Main(string[] args)
        {
                string[] month = new string[12] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
                int[] sale = new int[12];
                int i,j;
                int MaxmumSales = sale[0];
                int MinimumSales = sale[0];
                int Sum = 0;
                int Avg = 0;
                int Monthpost=0;
            for (i = 0; i < month.Length; i++)
            {
                Console.Write("Enter sale for month {0} :", i);
                sale[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(j=0;j<month.Length;j++)
            { 
                if (sale[j] >= MaxmumSales)
                {
                    MaxmumSales = sale[j];
                    Monthpost = j;
                }
                else if (sale[j] <=MinimumSales)
                {
                    MinimumSales = sale[j];
                    Monthpost = j;
                }
                Sum = Sum + sale[j];
            }
                Avg = Sum/sale.Length;
                Console.WriteLine("Maxmum Sales:{0}" + month[Monthpost]);
                Console.WriteLine("Minimum Sales:{0}" + month[Monthpost]);
                Console.WriteLine("Average Sales: " + Avg);
        }
    }
}
