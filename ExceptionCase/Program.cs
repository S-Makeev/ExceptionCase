using ExceptionsLibrary;
using System;

namespace ExceptionCase
{
    class Program
    {
        static void Main(string[] args)
        {
            DemoCode demo = new DemoCode();
            try
            {
                int result = demo.GrandParentMethod(4);
                Console.WriteLine($"The value at the given position is {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            Console.ReadLine();
        }
    }
}
