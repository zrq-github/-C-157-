using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tip33
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine(MyList.Func<int>());
        //    Console.WriteLine(MyList.Func<int>());
        //    Console.WriteLine(MyList.Func<string>());
        //}

        //class MyList
        //{
        //    static int count;
        //    public static int Func<T>()
        //    {
        //        return count++;
        //    }
        //}

        //static void Main(string[] args)
        //{
        //    MyList list1 = new MyList();
        //    MyList list2 = new MyList();
        //    Console.WriteLine(MyList.Count);

        //}
        //class MyList
        //{
        //    public static int Count { get; set; }
        //    public MyList()
        //    {
        //        Count++;
        //    }
        //}

        static void Main(string[] args)
        {
            MyList<int> list1 = new MyList<int>();
            MyList<int> list2 = new MyList<int>();
            MyList<string> list3 = new MyList<string>();
            Console.WriteLine(MyList<int>.Count);
            Console.WriteLine(MyList<string>.Count);
            Console.ReadKey();
        }
        class MyList<T>
        {
            public static int Count { get; set; }
            public MyList()
            {
                Count++;
            }
        }
    }
}
