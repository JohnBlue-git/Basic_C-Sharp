/*
Auther: John Blue
Time: 2022/5
Platform: VS2017
Object: to use Enum
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumExample
{
    class EnumExample
    {
        enum Days { Sun, Mon, tue, Wed, thu, Fri, Sat };

        enum Cate : byte
        {
            Electronics = 1,
            Food = 5,
            Automotive = 6,
            Arts = 10,
            BeautyCare = 11,
            Fashion = 15
        }

        static void Main(string[] args)
        {
            int x = (int)Days.Sun;
            int y = (int)Days.Fri;
            Console.WriteLine("Sun = {0}", x);
            Console.WriteLine("Fri = {0}", y);

            Console.WriteLine(Cate.BeautyCare);
            Console.WriteLine("BeautyCare = {0}", (int)Cate.BeautyCare);

            Console.ReadKey();
        }
    }
}
