using System;
using System.Collections.Generic;

namespace Tip38_Ture_Equal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Action> lists = new List<Action>();
            for (int i = 0; i < 5; i++)
            {
                TempClass tempClass = new TempClass();
                tempClass.i = i;
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