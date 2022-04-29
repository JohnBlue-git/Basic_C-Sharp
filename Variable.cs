﻿/*
Auther: John Blue
Time: 2022/5
Platform: VS2017
Object: variable type (..., static, const, ...)
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    class Variable
    {
        //public static const double PI = 3.14159;// not allowed static const
        public static double PI = 3.14159;
        static int xx = yy;
        static int yy = 6;

        public const int x = 10;// const default as static
        public int length;

        static void Main(string[] args)
        {
            // local const
            const int local = 10;

            // object
            Variable m = new Variable();
            //m.x = 10; // Compile Error

            // member variable
            Console.WriteLine(m.length);

            // static variable
            Console.WriteLine(Variable.x);// const default as static
            Console.WriteLine(Variable.PI);

            Console.WriteLine(Variable.xx);
            Console.WriteLine(Variable.yy);
            Variable.xx = 9;
            Console.WriteLine(Variable.xx);

            // end
            Console.ReadKey();
        }
    }
}
