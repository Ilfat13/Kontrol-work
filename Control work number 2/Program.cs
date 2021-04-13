using System;
using System.Collections.Generic;

namespace Control_work_number_2
{
    class Program
    {
        public static Random random = new Random();
        static void Main()
        {
            int n = 10;
            List<double> num = new List<double>();

            for (int i = 0; i < n; i++)
            {
                num.Add(random.NextDouble() * 50);
            }

            foreach (double item in num)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            List<double> newnum = new List<double>();
            for (int i = 0; i < n; i++)
            {
                newnum.Add(Sum(num, i));
            }

            foreach (double item in newnum)
            {
                Console.WriteLine(item);
            }

        }
        public static double Sum(List<double> num, int i)
        {
            double sum = 0;
            for (int j = 0; j < i + 1; j++)
                sum += num[j];
            return sum;

        }
    }
}
    
           