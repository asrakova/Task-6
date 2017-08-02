using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    class Program
    {
        static double AK(int n, double[] stock, int m, double l)
        {
            double res = 0;
            if (n == 1) res = stock[1];
            else if (n == 2) res = stock[2];
            else if (n == 3) res = stock[3];
            else res = (7 / 3 * AK(n - 1, stock, m, l) + AK(n - 2, stock, m, l)) / 2 * AK(n - 3, stock, m, l);
            if (stock[0] < m) result(res, n, l, stock);
            return res;
        }

        static void result(double res, int n, double l, double[] stock)
        {
            stock[n] = res;
            if (res > l) stock[0] += 1;
        }


        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[] stock = new double[n];
            stock[0] = 0;
            stock[1] = double.Parse(Console.ReadLine());
            stock[2] = double.Parse(Console.ReadLine());
            stock[3] = double.Parse(Console.ReadLine());

            AK()
        }
    }
}
