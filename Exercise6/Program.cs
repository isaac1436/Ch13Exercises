class Exercise6
{
    static void Main()
    {
        string phrase = "We are living in a yellow submarine. We don't have anything else.";

        string[] hook = { " ", "." };

        string[] split = phrase.Split(hook, StringSplitOptions.RemoveEmptyEntries);

        split[5] = split[5].ToUpper();
        split[6] = split[6].ToUpper();
        split[split.Length - 2] = split[split.Length - 2].ToUpper();

        Console.WriteLine("\n");

        for (int i = 0; i < split.Length; i++)
        {
            Console.Write(split[i] + " ");
        }

    }
}