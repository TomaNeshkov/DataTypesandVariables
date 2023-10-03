using System;
    class Program
{
        static void Main(string[] args)
    {
            string name = Console.ReadLine();
            int pop = int.Parse(Console.ReadLine());
            int square = int.Parse(Console.ReadLine());
            Console.WriteLine($"Town {name} has population of {pop} and area {square} square km.");

    }
}