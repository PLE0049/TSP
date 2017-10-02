using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Limity
{
    class Program
    {
        public static int NumberOfPermutations = 0;
        static void Main()
        {
            var stopwatch = new Stopwatch();

            for(int NumberOfPoints = 4; NumberOfPoints < 15; NumberOfPoints++)
            {
                string str = "bcdefghijklmnopqrstuvw";
                char[] arr = str.Substring(0, NumberOfPoints).ToCharArray();
                stopwatch.Start();
                GetPer(arr);
                var elapsed_time = stopwatch.ElapsedMilliseconds;

                Console.WriteLine("Time for " + NumberOfPoints + " poits is: " + elapsed_time + " ms.");
                Console.WriteLine("Number of permutations: " + NumberOfPermutations);
                NumberOfPermutations = 0;
            }
        }
        private static void Swap(ref char a, ref char b)
        {
            if (a == b) return;

            a ^= b;
            b ^= a;
            a ^= b;
        }

        public static void GetPer(char[] list)
        {
            int x = list.Length - 1;
            GetPer(list, 0, x);
        }

        private static void GetPer(char[] list, int k, int m)
        {
            if (k == m)
            {
                /*
                Console.Write("a");
                Console.Write(list);
                Console.Write("a");
                Console.WriteLine();
                */
                NumberOfPermutations++;
            }
            else
                for (int i = k; i <= m; i++)
            {
                Swap(ref list[k], ref list[i]);
                GetPer(list, k + 1, m);
                Swap(ref list[k], ref list[i]);
            }
        }

    }
}
