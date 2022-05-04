/*
Auther: John Blue
Time: 2022/5
Platform: VS2017
Object: display how to use try catch
Reference(File):https://www.runoob.com/csharp/csharp-file-io.html
*/

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchExamaple
{
    class TryCatchExamaple
    {
        public void file_fun()
        {
            FileStream f;
            try
            {
                f = new FileStream("abc.txt", FileMode.Open, FileAccess.Read, FileShare.Read);// create object
            }
            // if abc.txt does not exist, FileNotFoundException will be caught
            catch (FileNotFoundException fnf)
            {
                Console.WriteLine("File not found. Generate an exception and throw it");
                throw fnf;// !!! throw object
            }
            f.Close();
        }

        static void Main(string[] args)
        {
            // try block
            Console.WriteLine("Try Catch block >>");
            try
            {
                int[] myNumbers = { 1, 2, 3 };
                Console.WriteLine(myNumbers[10]);
            }
            // catch (... e?) {
            // ...
            //}
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong.");
            }
            finally
            {
                Console.WriteLine("The 'try catch' is finished.");
            }

            // throws
            Console.WriteLine("Throws >>");
            TryCatchExamaple s = new TryCatchExamaple();
            try
            {
                s.file_fun();
            }
            catch (FileNotFoundException ef)
            {
                Console.WriteLine("File not found.");
                Console.WriteLine("Error: {0}" + ef.Message);
            }
            catch (Exception epp)
            {
                Console.WriteLine("An Exception has been caught.");
                Console.WriteLine("Error: {0}" + epp.Message);
            }



            Console.ReadKey();
        }
    }
}
