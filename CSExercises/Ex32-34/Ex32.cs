using System;
namespace CSExercises
{
    public class Ex32
    {
        public static void Main(string[] args)
        {
                string[] month = new string[12] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
                double[] sale = new double[12];
                int i;
                double MaxmumSales = sale[0];
                double MinimumSales = sale[0];
                double Sum = 0;
                double Avg = 0;
                int Monthpost=0;
            for (i = 0; i < month.Length; i++)
            {
                Console.Write("Enter sale for month {0} :", i);
                sale[i] = Convert.ToDouble(Console.ReadLine());
                if (sale[i] >= MaxmumSales)
                {
                    MaxmumSales = sale[i];
                    Monthpost = i;
                }
                if (sale[i] <= MinimumSales)
                {
                    MinimumSales = sale[i];
                    Monthpost = i;
                }
                Sum = Sum + sale[i];
            }
                Avg = Sum / 12;
                Console.WriteLine("Maxmum Sales:{0}" + month[Monthpost]);
                Console.WriteLine("Minimum Sales:{0}" + month[Monthpost]);
                Console.WriteLine("Average Sales: " + Avg);
        }
    }
}
