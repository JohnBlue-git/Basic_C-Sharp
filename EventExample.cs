/*
Auther: John Blue
Time: 2022/5
Platform: VS2017
Object: to use delegation and event and display publisher subscriber model
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventExample
{
    class EventExample
    {
        /***********publisher***********/
        public class EventTest
        {
            private int value;

            // 先定義 delegation
            public delegate void NumManipulationHandler();

            // 在定義 event
            public event NumManipulationHandler ChangeNum;

            // event 存在則觸發; 不存在則default
            protected virtual void OnNumChanged()
            {
                if (ChangeNum != null)
                {
                    ChangeNum(); // 被觸發 且存在 那就執行ChangeNum...也就是執行subscriber
                    Console.WriteLine(", value = {0}", value);
                }
                else
                {
                    Console.WriteLine("event not fire, value = {0}", value);
                }

                Console.ReadKey(); // wait for enter to continue
            }


            //  發布器 constructor
            public EventTest()
            {
                int n = 5;
                SetValue(n);
            }

            // 發布器的 動作
            public void SetValue(int n)
            {
                if (value != n)
                {
                    value = n;
                    OnNumChanged();// 呼叫event觸發判斷
                }
            }

        }


        /***********subscriber***********/

        public class subscribEvent
        {
            public void printf()
            {
                Console.Write("event fire");
            }
        }


        public static void Main()
        {
            // 第一次没有触发事件, 因為event ChangeNum尚未存在
            EventTest e = new EventTest();

            // 開始給 ChangeNum
            subscribEvent v = new subscribEvent();
            e.ChangeNum += new EventTest.NumManipulationHandler(v.printf); // 注册 

            // 有動作觸發
            e.SetValue(7);
            e.SetValue(11);
        }
    }
}
