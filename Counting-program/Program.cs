using System;

namespace Counting
{
    class program

{

    static void Main(string[] args)
    {
        Console.Write("Enter string :");
        string myString = Console.ReadLine();
        int count = 0;

        foreach (char item in myString)
        {
           
            if (!char.IsWhiteSpace(item))
            {
                count++;
            }
        }

        Console.WriteLine("Total letters: " + count);
        Console.ReadLine();
    }
}
}