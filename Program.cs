using System;
using System.Linq;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Please type a word to reverse it");
        string? str = Console.ReadLine();
        if (str != null)
        {
        string revStr = new string(str.Reverse().ToArray());
        Console.WriteLine("The reveresed word is " + revStr);
        }
        else
        {
            Console.WriteLine("You have not entered a word");
        }

    }
}