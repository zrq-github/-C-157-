﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tip95
{
    class Program
    {

        static void Main()
        {
            American american = new American();
            Console.ReadKey();
        }

        class Person
        {
            public Person()
            {
                InitSkin();
            }

            protected virtual void InitSkin()
            {
                //省略
            }
        }

        class American : Person
        {
            // 这样写可以避免错误
            //Race Race = new Race() { Name = "123" };
            Race Race;

            public American()
                : base()
            {
                Race = new Race() { Name = "White" };
            }

            protected override void InitSkin()
            {
                Console.WriteLine(Race.Name);
            }
        }

        class Race
        {
            public string Name { get; set; }
        }

    }
}
