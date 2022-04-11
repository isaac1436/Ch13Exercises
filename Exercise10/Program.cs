using System.Text;
class Exercise10
{
    static void Main()
    {
        string phrase = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight so we " +
            "are drinking all the day. We will move out of it in five days";

        string hook = " "; 

        char hook2 = '.';

        string keyword = "in";

        string[] firstSplit = phrase.Split(hook2, StringSplitOptions.RemoveEmptyEntries);
        StringBuilder results=new StringBuilder();

        for (int i = 0; i < firstSplit.Length; i++)
        {
            string[] secondSplit = firstSplit[i].Split(hook, StringSplitOptions.RemoveEmptyEntries);

            for (int j=0;j<secondSplit.Length;j++)
            {
                if(secondSplit[j] == keyword)
                {
                    results.Append(firstSplit[i]+". ");
                }
            }
        }

        Console.WriteLine(results.ToString());

    }
}