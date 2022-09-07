using System;
using System.Drawing.Printing;

namespace Tip46_zrq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SampleClass sampleClass = new SampleClass();
            SampleClass goOne = sampleClass;
            SampleClass goTwo = sampleClass;
            goOne.Dispose();
            var index = goTwo.SampleClassB.Index;
            Console.ReadKey();
        }
    }
    public class SampleClass : IDisposable
    {
        public SampleClassB SampleClassB { get; set; }
        public SampleClass()
        {
            SampleClassB = new SampleClassB();
        }
        public void Dispose()
        {
            SampleClassB = null;
        }
    }
    public class SampleClassB
    {
        public int Index { get; set; } = 0;
        public SampleClassB() { }
    }
}