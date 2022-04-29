/*
Auther: John Blue
Time: 2022/5
Platform: VS2017
Object: display break continue goto control flow
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    class BreakContinueExample
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Begin loop:");
            for (int i = 0; i < 6; i++) {
                for (int j = 0; j < 6; j++) {
                    if (i == 0 && j == 4)
                    {
                        break;
                    }
                    if (i == 4) {
                        continue;
                    }
                    Console.Write("({0},{1})", i, j);
                    Console.WriteLine();
                }
            }

            Console.ReadKey();
        }
    }
}
