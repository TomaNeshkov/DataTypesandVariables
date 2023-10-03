using System;

class Program
{
    static void Main(string[] args)
    {
        int charValue = Console.Read();

        if (charValue != -1)
        {
            char inputChar = (char)charValue;

            if (char.IsUpper(inputChar))
            {
                Console.WriteLine("upper-case");
            }
            else if (char.IsLower(inputChar))
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}
