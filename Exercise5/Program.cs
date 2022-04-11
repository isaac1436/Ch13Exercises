class Exercise5
{
    static void Main()
    {
        string phrase = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight so we " +
            "are drinking all the day. We will move out of it in five days";

        string[] hook = { "in","In" };

        string[] split = phrase.Split(hook[0], StringSplitOptions.RemoveEmptyEntries);

        Console.WriteLine("\nThere are {0} occurences of the keyword \"{1}\" ", split.Length, hook[0]);

    }
}