/*
Auther: John Blue
Time: 2022/5
Platform: VS2017
Object: some simple practice
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Practice
    {
        // round
        public static int round(double y)
        {
            return (int)(y + 0.5);
        }

        // 1 + 2 + ... + n
        public static int sum(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            return n + sum(n - 1);
        }

        public static int gcd_rec(int x, int y)
        {
            // if x < y then exchange x y
            if (x % y == 0)
            {
                return y;
            }
            return gcd_rec(y, x % y);
        }

        public static int gcd(int x, int y)
        {
            int tmp;
            // if x < y then exchange x y
            while (x % y != 0)
            {
                tmp = y;
                y = x % y;
                x = tmp;
            }
            return y;
        }

        static void Main(string[] args)
        {
            // round
            double x = 20.6;
            Console.WriteLine("{0} round {1}", x, (int)(x + 0.5));
            Console.WriteLine("{0} round {1}", x, round(x));

            // recusive 1 + 2 + ... + n
            Console.WriteLine(sum(100));

            // great common denominator
            Console.WriteLine(gcd(12, 18));
            Console.WriteLine(gcd_rec(12, 18));


            Console.ReadKey();
        }
    }
}
