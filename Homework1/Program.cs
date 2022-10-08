using System;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name");

            string name = Console.ReadLine();

            Console.WriteLine("Enter your surname");

            string surName = Console.ReadLine();

            Console.WriteLine("you are");

            Console.WriteLine($"{name} {surName}");
        }
    }
}
