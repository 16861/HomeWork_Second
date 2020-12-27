using System;
using System.Collections.Generic;

namespace third_task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Third task! sorted list");

            SortedList<string, int> list = new SortedList<string, int>();

            list.Add("A row", 1);
            list.Add("C row", 3);
            list.Add("D row", 4);
            list.Add("B row", 2);
            
            var keys = list.Keys;

            Console.WriteLine("Alphabetical order: ");
            foreach(var x in keys) 
                Console.Write("Key: {0}, value: {1} ", x, list[x]);

            Console.WriteLine();

            Console.WriteLine("Opposite to alphabetical order: ");
            for(int i = keys.Count-1; i >= 0; i--)
                Console.Write("Key: {0}, value: {1} ", keys[i], list[keys[i]]);

            Console.WriteLine();
        }
    }
}
