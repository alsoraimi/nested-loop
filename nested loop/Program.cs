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
            StairCase(8);

        }

        public static void StairCase(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(new String(' ', n - i) + new String('#', i));


            }
        }
    }
}
