using System;
namespace CSExercises
{
    public class Ex32
    {
        public static void Main(string[] args)
        {
            string[] month = new string[12] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
            double[] sale = new double[12];
            int i, j;
            double MaxmumSales = sale[0];
            double MinimumSales = sale[0];
            double Sum = 0;
            double Avg = 0;
            for (i = 0; i < month.Length; i++)
            {
                Console.Write("Enter sale for month {0} :" , i);
                sale[i] = Convert.ToDouble(Console.ReadLine());
                if (MaxmumSales >= sale[i])
                {
                    MaxmumSales = sale[0];
                }              
                if (MinimumSales <= sale[i])
                {
                    MinimumSales = sale[0];
                }
                Sum = Sum + sale[i];
            }
            Avg = Sum / 12;
            Console.WriteLine("Maxmum Sales:" + MaxmumSales);
            Console.WriteLine("Minimum Sales:" + MinimumSales);
            Console.WriteLine("Average Sales: " + Avg);
        }
    }
}
