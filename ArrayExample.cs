/*
Auther: John Blue
Time: 2022/5
Platform: VS2017
Object: to use Array
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    class ArrayExample
    {
        public static void fun(int[,] x)
        {
            for (int i = 0; i < x.GetLength(0); i++)
            {
                for (int j = 0; j < x.GetLength(1); j++)
                {
                    Console.Write(x[i, j]);
                }
                Console.WriteLine();
                /*
                .Rank for the number of dimensions.
                .GetLength(0) for the number of rows
                .GetLength(1) for the number of columns
                .Length for total number
                */
            }
        }

        public static void rug(int[][] x)
        {
            for (int i = 0; i < x.Length; i++)
            {
                for (int j = 0; j < x[0].Length; j++)
                {
                    Console.Write(x[i][j]);
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            //// rug array
            // (1) 1D
            int[] x; // x is a reference to int[]
            x = new int[10];
            //x.Length = 1; // Compile Error: length is final
            for (int i = 0; i < x.Length; i++)
            {
                x[i] = i;
            }

            // (2) 1D
            int[] y = new int[] { 1, 2, 3, 4, 5 };
            for (int i = 0; i < y.Length; i++)
            {
                y[i] = i;
            }

            // (3) 2D
            int[][] m;
            m = new int[3][];
            for (int i = 0; i < m.Length; i++)
            {
                m[i] = new int[6];
                for (int j = 0; j < m[i].Length; j++)
                {
                    m[i][j] = i + j;
                }
            }

            // (4) 2D triangle
            int[][] t;
            t = new int[3][];
            for (int i = 0; i < t.Length; i++)
            {
                t[i] = new int[i];
                for (int j = 0; j < t[i].Length; j++)
                {
                    t[i][j] = i + j;
                }
            }
            // (5) (passing)
            Console.WriteLine("Rugged array");
            rug(m);
            Console.WriteLine();


            //// normal array
            // (1) 2D
            int[,] n = new int[3, 6];
            for (int i = 0; i < m.Length; i++)
            {
                for (int j = 0; j < m[i].Length; j++)
                {
                    n[i, j] = i + j;
                }
            }
            // (2) (passing)
            Console.WriteLine("Normal array");
            fun(n);
            Console.WriteLine();

            // end
            Console.ReadKey();
        }
    }
}
