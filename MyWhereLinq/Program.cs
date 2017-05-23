using System;
using System.Collections.Generic;

namespace ConsoleApplication7
{
    public static class A
    {
        public static List<T> MyWhere<T>(this IEnumerable<T> collection, Func<T, bool> func)
        {
            var result = new List<T>();
            foreach (var elem in collection)
            {
                if (func(elem))
                {
                    result.Add(elem);
                }
            }
            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var a = new List<int>
            {
                1,
                2,
                3,
                4,
                5,
                6
            };

            var b = a.MyWhere(i => i < 4);
            foreach (var i in b)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}