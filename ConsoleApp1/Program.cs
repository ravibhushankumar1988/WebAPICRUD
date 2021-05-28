using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        int a = 10;
        int b = 20;

        public int Add(int a , int b)
        {
            return a + b;
        }

        public int Add(ref int a, ref int b)
        {
            return a + b;
        }

        public int Add(out int a, out int b)
        {
            a = 10;
            b = 10;
            return a + b;
        }

        static void Main(string[] args)
        {
            int[] rr = { 3, 2, 3, 3 };

            var result = rr.GroupBy(a => a).Select(x => new { key = x.Key, val = x.Count() });

            
            foreach(var item in result)
            {
                Console.WriteLine($"Key : {item.key}    Value : {item.val}");
            }

            

        }
    }
}
