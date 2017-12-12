using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Za_kontrolna
{
    class Program
    {
        static double Sum3(double x, int a)
        {
            double res = Math.Pow(x + a, 3);
            return res;
        }
        static void Main(string[] args)
        {
            Console.Write("x= ");
            double x = Convert.ToDouble(Console.ReadLine());
            double result = 10 * x * Sum3(x, 5) + Sum3(x, 2);
            Console.WriteLine("Result is " + result);

            Console.Write("n= ");
            int n = Convert.ToInt32(Console.ReadLine());
            while (n <= 0)
            {
                Console.Write("new n: ");
                n = Convert.ToInt32(Console.ReadLine());
            }
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("a[{0}]= ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (a[i] < a[j])
                    {
                        int p = a[i];
                        a[i] = a[j];
                        a[j] = p;
                    }
                }
            }
            foreach (int i in a)
            {
                Console.WriteLine("{0}", i);
            }
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum = sum + Sum3(x, a[i]);
            }
            Console.WriteLine("The sum is " + sum);
            Console.ReadKey(true);
        }
    }
}
