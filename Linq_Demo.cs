/*

*/

using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace Demo
{
    public struct Member
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    
    class MainClass
    {
        public static void Main(string[] args)
        {
            // loading data
            List<Member> memberList = new List<Member>();
            memberList = new List<Member>() { 
                new Member(){Name="Y",Age=18},
                new Member(){Name="G",Age=20},
                new Member(){Name="L",Age=19},
                new Member(){Name="N",Age=12}
            };
            
            
            
            // for each way:
            // to sub-set data above age 10
            List<Member> query = new List<Member>();
            foreach (Member item in memberList) {
                if (item.Age > 10) {
                    query.Add(item);
                }
            }
            Console.Write("query: ");
            foreach (Member item in query)
            {
                Console.Write("({0},{1}) ", item.Name, item.Age);
            }
            Console.WriteLine("\n");
            
            
            
            // Linq way
            // to sub-set data above age 10
            /*
            var find = from data in this._memberList
                       where data.Age > 10 && ...
                       select data;
            */
            var find = from data in memberList
                       where data.Age > 10
                       select data;
            Console.Write("Linq: ");
            foreach (Member item in find)
            {
                Console.Write("({0},{1}) ", item.Name, item.Age);
            }
        }
    }

}
