using System;
namespace CSExercises
{
    public class Ex22
    {
        public static void Main(string[] args)
        {
            int A,B,a,b;
            Console.Write("Enter A: ");
            A = Convert.ToInt32(Console.ReadLine());
            a = A;
            Console.Write("Enter B: ");
            B = Convert.ToInt32(Console.ReadLine());
            b = B;
            do
            {
                if (a > b)
                    a = a - b;
                else
                    b = b - a;
            } while (a != b);
                Console.WriteLine("HCF:{0}",a);
                Console.WriteLine("LCM:{0}",(A*B)/a);
        }
    }
}
