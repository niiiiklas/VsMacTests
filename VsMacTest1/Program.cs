using System;

namespace VsMacTest1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            args = GetArgs1();

            CsWriter.Start.Go(args);

            Console.WriteLine("Hello World!");
        }


        public static string[] GetArgs1()
        {
            return new string[] {
                "h"
            };
        }
    }
}
