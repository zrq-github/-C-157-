using System;
using System.Collections.Generic;

namespace Tip43_zrq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<Programmer> programmers = new List<Programmer>();
            //List<Employee> employees = programmers;

            IEnumerable<Programmer> programmers = new List<Programmer>();
            IEnumerable<Employee> employees = programmers;
        }
    }
    class Employee
    {
        public string Name { get; set; }
    }
    class Programmer : Employee
    {
    }
    class Manager : Employee
    {
    }
}