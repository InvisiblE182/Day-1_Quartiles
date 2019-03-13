using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_1_Quartiles
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] input = { 3, 7, 8, 5, 12, 14, 21, 13, 18 };
            Day_1_Quartiles(9, input);
            
        }

        public static void Day_1_Quartiles(int n, int[] input)
        {
            Program p = new Program();
            decimal median = p.Median(input);

            List<int> lowerHalf = new List<int>();
            List<int> upperHalf = new List<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] < median)
                {
                    lowerHalf.Add(input[i]);
                }
                else if (input[i] > median)
                {
                    upperHalf.Add(input[i]);
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine(p.Median(lowerHalf.ToArray()));
            Console.WriteLine(p.Median(input));
            Console.WriteLine(p.Median(upperHalf.ToArray()));
            Console.ReadLine();
        }

        public decimal Median (int[] input)
        {
            Array.Sort(input);
            decimal medLower = 0;
            decimal medHigher = 0;

            if (input.Length % 2 == 0)
            {
                medLower = input[(input.Length - 1) / 2];
                medHigher = input[(input.Length - 1) / 2 + 1];
            }
            else
            {
                medLower = input[(input.Length - 1) / 2];
                medHigher = input[(int)Math.Round((input.Length - 1) / 2.0, 0, MidpointRounding.AwayFromZero)];
            }
            return decimal.Round((medLower + medHigher) / 2, 1);
        }
    }
}
