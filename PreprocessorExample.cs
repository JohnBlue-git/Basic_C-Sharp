﻿/*
 Auther: John Blue
 Time: 2022/5
 Platform: VS2017
 Object: to show how to use preprocessor
 */

#define DEBUG
#define VC_V10

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreprocessorExample
{
    class PreprocessorExample
    {
        static void Main(string[] args)
        {
            #if (DEBUG && !VC_V10)
                     Console.WriteLine("DEBUG is defined");
            #elif (!DEBUG && VC_V10)
                     Console.WriteLine("VC_V10 is defined");
            #elif (DEBUG && VC_V10)
                        Console.WriteLine("DEBUG and VC_V10 are defined");
            #else
                     Console.WriteLine("DEBUG and VC_V10 are not defined");
            #endif


            Console.ReadKey();
        }
    }
}
