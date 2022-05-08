/*
Auther: John Blue
Time: 2022/5
Platform: VS2017
Object: to use Delegation
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegationExample
{
    // announce delegation
    delegate int NumberChanger(int n);

    class DelegationExample
    {

        static int num = 1;

        public static int AddNum(int p)
        {
            num += p;
            return num;
        }

        public static int MultNum(int q)
        {
            num *= q;
            return num;
        }

        public static int getNum()
        {
            return num;
        }

        public static void do_it(NumberChanger fun)
        {
            fun(666);
        }

        static void Main(string[] args)
        {

            // 创建委托实例
            NumberChanger nc1 = new NumberChanger(AddNum);
            NumberChanger nc2 = new NumberChanger(MultNum);
            // 使用委托对象调用方法
            nc1(25);// add: 1 + 25 = 26
            Console.WriteLine("Value of Num: {0}", getNum());
            nc2(5);// multiple: 26 * 5 = 130
            Console.WriteLine("Value of Num: {0}", getNum());
            do_it(nc1);// add: 130 + ... = 796
            Console.WriteLine("Value of Num: {0}", getNum());

            Console.ReadKey();
        }
    }
}
