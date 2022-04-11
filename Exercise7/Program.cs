using System;
using System.Text;
using System.Text.RegularExpressions;
class Exercise7
{
    static void Main()
    {
        Console.Write("Please enter a string: ");
        string str = Console.ReadLine();

        if (str.Length > 20)
        {
            Console.WriteLine("\nThe string entered passes the length specifications set up.");
        }

        else if (str.Length <= 20)
        {
            Console.WriteLine("\n{0}", str.PadRight(20, '*'));
        }
    }
}