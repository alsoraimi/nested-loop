using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nested_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            //StairCase(8);
            //Staircase2(8);
            // Staircase3(8);
            Staircase4(8);
        }

        public static void Staircase(int n) //1 b
        {
            {
                for (int i = n; i >= 1; i--)
                {
                    Console.WriteLine(new String('#', i) + new String(' ', n + i));


                }

            }

        }

        public static void Staircase2(int n) // 1A

        {
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(new String('#', i) + new String(' ', n - i));


            }

        }

        public static void StairCase3(int n)// problem 1D
        {
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(new String(' ', n - i) + new String('#', i));


            }
        }

        public static void Staircase4(int n)// 1C

        {
            for (int i = n; i >= 1; i--)
            {
                Console.WriteLine(new String(' ', n - i) + new String('#', i));


            }

        }

    }
}

