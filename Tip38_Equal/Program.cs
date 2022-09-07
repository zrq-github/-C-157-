using System;
using System.Collections.Generic;

namespace Tip38_Equal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Action> lists = new List<Action>();
            TempClass tempClass = new TempClass();
            for (tempClass.i = 0; tempClass.i < 5; tempClass.i++)
            {
                Action t = tempClass.TempFuc;
                lists.Add(t);
            }
            foreach (Action t in lists)
            {
                t();
            }
        }

        class TempClass
        {
            public int i;
            public void TempFuc()
            {
                Console.WriteLine(i.ToString());
            }
        }
    }
}