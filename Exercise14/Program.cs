using System.Text;
class Exercise14
{
    static void Main()
    {
        string seperator = " ";

        Console.Write("Enter a phrase of your choice: ");
        string phrase=Console.ReadLine();
        string[] words=phrase.Split(seperator, StringSplitOptions.RemoveEmptyEntries);

        StringBuilder reversed=new StringBuilder();

        for(int i=words.Length-1;i>=0;i--)
        {
            reversed.Append(words[i]);
            reversed.Append(' ');
        }

        Console.WriteLine(reversed);

    }
}