using System;
using StackExchange.Redis;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var connectionMultiplexer = ConnectionMultiplexer.Connect("localhost:6379");
            var database = connectionMultiplexer.GetDatabase();
            Console.WriteLine("Done!");
        }
    }
}
