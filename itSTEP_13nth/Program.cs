using System;

namespace itSTEP_13nth
{
    class Program
    {
        static void Main(string[] args)
        {
            Temperature temp = new Temperature();
            try
            {
                temp.showTemp();
            }
            catch (IsZeroException e)
            {
                Console.WriteLine("IsZeroException: {0}", e.Message);
            }
            Console.ReadKey();
        }
    }
    public class IsZeroException : Exception
    {
        public IsZeroException(string message) : base(message)
        {
        }
        public IsZeroException()
        {
        }
    }
    public class Temperature
    {
        int temperature = 0;

        public void showTemp()
        {

            if (temperature == 0)
            {
                throw (new IsZeroException("Zero Temperature exception"));
            }
            else
            {
                Console.WriteLine("Temperature: {0}", temperature);
            }
        }
    }
}

