using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var userName = Console.ReadLine();

            Console.WriteLine($"Hello {userName}, what is your favorite color?");
            var color = Console.ReadLine();

            Console.WriteLine($"That's great, what is your favorite animal?");
            var animal = Console.ReadLine();

            Console.WriteLine($"Cool cool and what is your favorite band?");
            var band = Console.ReadLine();
        }
    }
}

