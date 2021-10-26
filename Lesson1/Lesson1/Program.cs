using System;

namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            String name = Console.ReadLine();
            String today = DateTime.Today.ToShortDateString();
            Console.WriteLine($"Hello {name}!, today is {today}");
            Console.Read();
        }
    }
}
