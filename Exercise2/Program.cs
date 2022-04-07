using System.Text;
class Exercise2
{
    static void Main()
    {
        Console.Write("Please enter any word or phrase of your choice: ");
        string words = Console.ReadLine();
        StringBuilder sb = new StringBuilder(words.Length);

        for (int i = words.Length - 1; i >= 0; i--)
        {
            sb.Append(words[i]);
        }
        Console.WriteLine("{0} in reverse is: {1}", words, sb.ToString());
    }
}