using System.Collections.Generic;
using System;

namespace Tip38_Error
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Action> lists = new List<Action>();
            for (int i = 0; i < 5; i++)
            {
                Action t = () =>
                {
                    Console.WriteLine(i.ToString());
                };
                lists.Add(t);
            }
            foreach (Action t in lists)
            {
                t();
            }
        }
    }
}