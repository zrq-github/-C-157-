using System;
using System.Collections.Generic;

namespace Tip38_Ture
{
    internal class Program
    {
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
            }
            foreach (Action t in lists)
            {
                t();
            }
        }
    }
}