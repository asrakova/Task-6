using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    class Program
    {
        static double[] AK(double[] stock, int k, int m, double l, ref int numL)
        {
            double res = 0;
            if (k == 1)
                res = stock[1];
            else if (k == 2)
                res = stock[2];
            else if (k == 3)
                res = stock[3];
            else
            {
                double ak1 = AK(stock, k - 1, m, l, ref numL)[k - 1];
                double ak2 = AK(stock, k - 2, m, l, ref numL)[k - 2];
                res = 7.0 / 3.0;
                res = (res * ak1 + ak2) / 2 *
                     AK(stock, k - 3, m, l, ref numL)[k - 3];
            }
            if (numL == m)
                return stock;
            stock[k] = res;
            if (stock[k] > l)
                numL++;
            return stock;
        }

        static void result(double res, int n, double l, double[] stock)
        {
            stock[n] = res;
            if (res > l) stock[0] += 1;
        }


        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[] stock = new double[n+1];
            stock[0] = 0;
            stock[1] = double.Parse(Console.ReadLine());
            stock[2] = double.Parse(Console.ReadLine());
            stock[3] = double.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            int numL = 0;
            stock = AK(stock, n, m, l, ref numL);
            foreach (double t in stock)
                Console.Write("{0} ", t);
            Console.WriteLine();
            if (numL == m) Console.WriteLine("Причина остановки: найдены M элементов, которые больше L");
            else Console.WriteLine("Причина остановки: найдены N элементов");
            Console.ReadLine();
        }
    }
}
