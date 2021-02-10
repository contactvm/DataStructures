using System;
using System.Collections.Generic;
namespace Linear_DataStructures
{
    public class MaxStockProfit
    {
        public void GetMaxStockProfit(int[] s)
        {
            int maxProfit = 0;
            int day1 = 0;
            int day2 = 0;
            int sum;

            for (int i = 0; i < s.Length - 1; i++)
            {
                sum = s[i + 1] - s[i];

                if (sum > 0)
                {
                    System.Console.WriteLine(sum);
                    if (maxProfit == 0)
                    {
                        day1 = i;
                    }
                    maxProfit += sum;
                    day2 = i + 1;
                }
                else
                {
                    System.Console.WriteLine("day1 {0}  day 2 {1}", day1.ToString(), day2.ToString());
                    maxProfit = 0;
                    day1 = i + 1;
                }

            }
            System.Console.WriteLine("day1 {0}  day 2 {1}", day1.ToString(), day2.ToString());
        }

        public class Interval
        {
            public int Buy { get; set; }
            public int Sell { get; set; }
        }

        public void GetMaxStockProfit1(int[] a)
        {

            int n = a.Length;
            List<Interval> sol = new List<Interval>();

            if (n == 1)
            {
                System.Console.WriteLine("only 1 day price available");
            }
            if (n == 0)
            {
                System.Console.WriteLine("no items present in array");
            }


            int i = 0;
            int count = 0;
            while (i < n - 1)
            {

                while ((i < n - 1) && a[i] >= a[i + 1])//important condition  i<n-1 should be first after veriying array values because it gives index out of bound
                {
                    i++;
                }
                if (n - 1 == i)
                    break;
                Interval bs = new Interval();
                bs.Buy = i++;

                while ((i < n) && a[i] >= a[i - 1])
                {
                    i++;
                }
                bs.Sell = i - 1;
                sol.Add(bs);
                count++;
            }

            if (count == 0)
            {
                System.Console.WriteLine("no profit");
            }
            else
            {
                foreach (Interval it in sol)
                {
                    System.Console.WriteLine("buy ={0} sell {1}", it.Buy, it.Sell);
                }
            }

        }

        public int MaxCost(int[] prices)
        {
            int n = prices.Length;
            int cost = 0;
            int MaxCost = 0;

            if (n == 0)
            {
                return 0;
            }

            // store the first element of array in a variable
            int Min_price = prices[0];

            for (int i = 0; i < n; i++)
            {

                // now compare first element with all the
                // element of array and find the Minimum element
                Min_price = Math.Min(Min_price, prices[i]);

                // since Min_price is smallest element of the
                // array so subtract with every element of the
                // array and return the MaxCost
                cost = prices[i] - Min_price;

                MaxCost = Math.Max(MaxCost, cost);
            }
            return MaxCost;
        }

        public static void DriverCode()
        {

            MaxStockProfit m = new MaxStockProfit();
            int[] a = { 100, 180, 260, 310, 40, 535, 695 };

            m.GetMaxStockProfit(a);
            m.GetMaxStockProfit1(a);
            int[] b = { 20, 10, 5, 0 };
            m.GetMaxStockProfit1(b);
            System.Console.WriteLine(m.MaxCost(a));
            System.Console.WriteLine(m.MaxCost(b));

        }
    }
}