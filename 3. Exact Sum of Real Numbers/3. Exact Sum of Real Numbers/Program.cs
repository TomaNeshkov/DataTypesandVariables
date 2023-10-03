using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        decimal input = decimal.Parse(Console.ReadLine());
        decimal sum = 0;
        for (int i = 0; i < input; i++)
        {
            decimal num = decimal.Parse(Console.ReadLine());
            sum += num;
        }

        Console.WriteLine(sum);
    }
}