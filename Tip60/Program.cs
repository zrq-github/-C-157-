using System;

namespace Tip60
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            TryExcetion();
        }

        private static void TryExcetion()
        {
            try
            {
                try
                {
                    throw new NotImplementedException("内部异常");
                }
                catch (SystemException ex)
                {
                    //throw ex;
                    Exception userEx = new Exception("包装异常", ex);
                    throw userEx;
                }
            }
            catch (Exception ex)
            {
                Exception exception = ex.InnerException;
                Console.WriteLine(ex);
            }
        }
    }
}