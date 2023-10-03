using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        decimal pounds = decimal.Parse(Console.ReadLine());
        decimal km = pounds * 1.31m;
        Console.WriteLine($"{km:f3}");
    }
}