class Exercise13
{
    static void Main()
    {
        string seperator = @"/";

        Console.Write("Enter a URL of your choice: ");
        string url = Console.ReadLine();

        string[] comps = url.Split(seperator);
        string[] comp = { "Protocol", "Server", "Resource" };

        Console.WriteLine("The components are as follows: ");

        for (int i = 0; i < comp.Length; i++)
        {
            Console.WriteLine("[ {0} ] - \" {1} \" ", comp[i], comps[i]);
        }
    }
}