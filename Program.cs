using System;

namespace Variables_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cat = "Florida cat";
            int age = 3;
            char exclamation = '!';
            bool quick = false;
            double lives = 5.5;
            decimal feet = 5m;

            Console.WriteLine($"Hello {cat} !");
            Console.WriteLine($"My cat is {age} years old");
            Console.WriteLine($"He sings very well {exclamation} ");
            Console.WriteLine($"My cat thinks he's fast but that's very {quick} .");
            Console.WriteLine($"He has about {lives} lives left.");
            Console.WriteLine($"My cat can jump about {feet} feet high. ");
        }
    }
}
