using System;
using System.Collections.Generic;

// 测试更多匿名函数的IL代码
namespace Tip38_Multi
{
    internal class Program
    {
        public static int Index = 0;
        static void Main(string[] args)
        {
            List<Action> lists = new List<Action>();
            for (int i = 0; i < 5; i++)
            {
                int temp = i;
                Action t = () =>
                {
                    Console.WriteLine(temp.ToString());
                };
                lists.Add(t);

                Action b = () =>
                {
                    Console.WriteLine(i.ToString());
                    Console.WriteLine(Program.Index.ToString());
                };
                lists.Add(b);
            }
            foreach (Action t in lists)
            {
                t();
            }
            Console.ReadKey();
        }


        //public static int Index = 0;
        //static void Main(string[] args)
        //{
        //    List<Action> lists = new List<Action>();
        //    for (int i = 0; i < 5; i++)
        //    {
        //        Action t = () =>
        //        {
        //            Console.WriteLine(i.ToString());
        //        };
        //        lists.Add(t);

        //        Action b = () =>
        //        {
        //            Console.WriteLine(i.ToString());
        //            Console.WriteLine(Program.Index.ToString());
        //        };
        //        lists.Add(b);
        //    }
        //    foreach (Action t in lists)
        //    {
        //        t();
        //    }
        //    Console.ReadKey();
        //}
    }
}