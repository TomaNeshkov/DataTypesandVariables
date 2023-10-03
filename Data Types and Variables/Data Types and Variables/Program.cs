// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
﻿using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        decimal m = decimal.Parse(Console.ReadLine());
        decimal km = m / 1000;
        Console.WriteLine($"{km:f2}");
    }
}