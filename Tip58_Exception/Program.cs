namespace Tip58_Exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = DateTime.Now;
            var str = catchException();
            DateTime doDateTime = DateTime.Now;
            Console.WriteLine((doDateTime - dateTime).TotalSeconds);
            Console.ReadKey();
        }
        public static double NoException()
        {
            int index = 0;
            for (int i = 0; i < 1000000000; i++)
                index++;
            return index;
        }
        public static double tryException()
        {
            int index = 0;
            for (int i = 0; i < 1000000000; i++)
            {
                try
                {
                    index++;
                }
                catch
                {

                }
            }
            return index;
        }

        public static double catchException()
        {
            int index = 0;
            for (int i = 0; i < 1000000000; i++)
            {
                try
                {
                    throw new Exception();
                }
                catch
                {
                    index++;
                }
            }
            return index;
        }
    }
}