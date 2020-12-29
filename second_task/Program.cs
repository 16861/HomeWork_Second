using System;
using System.Collections;
using first_task;

namespace second_task
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Second task! Extension method");

            MyList<string> list = new MyList<string>();
            list.Add("first");
            list.Add("second");
            list.Add("third");
            list.Add("fourth");
            list.Add("fifth");

            Console.WriteLine(string.Join(" ", list.GetArray()));
        }
    }
}
