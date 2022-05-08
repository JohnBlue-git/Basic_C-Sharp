/*
Auther: John Blue
Time: 2022/5
Platform: VS2017
Object: to use Collection
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Container
{
    class Container
    {
        public static void show(System.Collections.Generic.IEnumerable<String> VL)
        {
            //foreach (String value in VL) {
            foreach (var value in VL) {
                Console.Write("{0}, ", value);
            }
            Console.WriteLine();
        }

        // main
        static void Main(string[] args)
        {
            // Array
            List<String> arr = new List<String>();
            arr.Add("list one");// 0
            arr.Add("list two");// 1
            arr.Add("list thre");// 2
            arr.Add("list four");// 3
            arr.Remove("list four");// remove 3
            Console.Write("Array: ");
            for (int i = 0; i < arr.Count; i++)
            {
                Console.Write("{0}, ", arr.ElementAt(i));
            }
            Console.WriteLine();
            show(arr);
            foreach (var ss in arr)
            {
                Console.Write("{0}, ", ss);
            }
            Console.WriteLine();
            Console.WriteLine();

            // Stack
            Stack<String> stk = new Stack<String>();
            stk.Push("stack one");
            stk.Push("stack two");
            stk.Push("stack three");
            Console.Write("Stack: ");
            show(stk);
            Console.WriteLine("peek: {0}", stk.Peek());
            Console.Write("item: ");
            while (stk.Count != 0)
            {// stk.empty() alternative
                Console.Write("{0}, ", stk.Pop());
            }
            Console.WriteLine();
            Console.WriteLine();

            // Queue
            Queue<String> que = new Queue<String>();// Queue is just an interface
            que.Enqueue("queue one");//queue.offer("queue one");
            que.Enqueue("queue two");
            que.Enqueue("queue three");
            Console.Write("Queue: ");
            show(que);
            Console.WriteLine("peek: {0}", que.Peek());
            Console.Write("item: ");
            while (que.Count == 0)
            {
                Console.Write("{0}, ", que.Dequeue());// que.remove() alternative
            }
            Console.WriteLine();
            Console.WriteLine();

            // LinkedList
            LinkedList<String> list = new LinkedList<String>();
            list.AddLast("LinkedList Runoob");
            list.AddFirst("LinkedList Google");
            list.AddLast("LinkedList Tesla");
            Console.Write("LinkedList: ");
            show(list);
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write("{0}, ", list.ElementAt(i));
            }
            Console.WriteLine();
            Console.WriteLine("first: {0}" + list.First());
            Console.WriteLine("last: {0}" + list.Last());
            list.RemoveFirst();
            list.RemoveLast();
            Console.Write("LinkedList: ");
            show(list);
            Console.WriteLine();
            
            // SortedSet ... could be implemented by hash table
            SortedSet<String> sorted_set = new SortedSet<String>();
            sorted_set.Add("one");
            sorted_set.Add("two");
            sorted_set.Add("three");
            //sorted_set.Remove("...");
            Console.Write("SortedSet: ");
            if (sorted_set.Count != 0)
            {
                show(sorted_set);
            }
            Console.WriteLine();
            // still C# have SortedDictionary<TKey,TValue> used as Map

            // HashSet
            HashSet<String> hash_set = new HashSet<String>();
            hash_set.Add("one");
            hash_set.Add("two");
            hash_set.Add("three");
            hash_set.Add("negative");
            Console.Write("HashSet: ");
            show(hash_set);
            Console.WriteLine("remove(- 1) ...");
            if (hash_set.Contains("- 1"))
            {
                hash_set.Remove("- 1");//remove(K, V)
            }
            Console.WriteLine();


            // Dictionary (Map) ... could be implemented by tree
            Dictionary<String, String> map = new Dictionary<String, String>();
            map.Add("3", "root");
            //map.Add("3", "duplicate root");// not allowed duplicate
            map.Add("6", "left");
            map.Add("9", "right");
            Console.Write("Map: ");
            if (map.Count != 0)
            {
                show(map.Keys);
                show(map.Values);
            }
            Console.WriteLine();
            //tree_map.clear();


            // The Generic Ductionary object in .NET does not accept duplicate keys
            //, which is a source of great annoyance to many .NET Developers.
            // LINQ does provide the .ToLookup extension method,
            // but the Lookup class does not have a constructor that would allow it to be created outside of a LINQ extension method call.
            // the easyest way to creacte duplicate is (!!! only for Map):
            // List<KeyValuePair<string, int>> d = new List<KeyValuePair<string, int>>();
            // d.Add(new KeyValuePair<string, int>("joe", 100));
            // d.Add(new KeyValuePair<string, int>("joe", 200));

            Console.ReadKey();
        }
    }
}
