using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;// !!! must using
using System.Threading.Tasks;

namespace C_Thread
{
    class Program
    {
        class Print
        {
            private string name;

            public Print(string nm)
            {
                name = nm;
            }

            public void set_name(string nm)
            {
                name = nm;
            }


            public void PrintTable()
            {
                lock (this)// lock itself so this function can only be used by one thread each time
                {
                    for (int i = 1; i <= 10; i++)
                    {
                        Thread.Sleep(100);
                        Console.WriteLine("{0}: {1}", name, i);
                    }
                }
            }
        }

        class MyList
        {
            public static List<int> list;

            public MyList() {
                list = new List<int>();
            }

            public void myAdd()
            {
                lock(list) {
                    for (int i = 0; i < 10; i++) {
                        list.Add(i);
                    }
                }
            }

            public static void show()
            {
                Console.Write("list: ");
                foreach (var i in list)
                {
                    Console.Write("{0} ", i);
                }
                Console.WriteLine();
            }
        }


        static void Main(string[] args)
        {
            // Thread ThreadStart and lock(this)
            Print p = new Print("one");
            Thread thd_e = new Thread(new ThreadStart(p.PrintTable));
            Thread thd_r = new Thread(new ThreadStart(p.PrintTable));
            thd_e.Start();
            Thread.Sleep(900);// operating around 1 second then change name
            p.set_name("second");
            thd_r.Start();// suppose to race with thd_e right afer one second but lock() stop the racing
            Thread.Sleep(3000);

            // lock(static list)
            MyList[] my = new MyList[3];
            my[0] = new MyList(); my[1] = new MyList(); my[2] = new MyList();
            Thread thd1 = new Thread(new ThreadStart(my[0].myAdd));
            Thread thd2 = new Thread(new ThreadStart(my[1].myAdd));
            Thread thd3 = new Thread(new ThreadStart(my[2].myAdd));
            thd1.Start();
            thd2.Start();
            thd3.Start();
            // can .join() to ask for the main thread to wait for the sub thread
            // .join(setting second here)
            thd1.Join();
            thd2.Join();
            thd3.Join();
            Console.WriteLine("static list size is " + MyList.list.Count);
            MyList.show();
            


            Console.ReadKey();
        }
    }
}
