using System.Text;
using System.Text.RegularExpressions;
class Exercise11
{
    static void Main()
    {
        Console.Write("Please enter any phrase of your choice: ");
        string phrase = Console.ReadLine();

        string[] forbiddenWords = { "ass", "fuck", "shit", "asshole" };

        string[] replacements = { "A**", "f**k", "sh*t", "A**hole" };

        string hook = " ";

        string[] phrase2 = phrase.Split(hook, StringSplitOptions.RemoveEmptyEntries);

        StringBuilder replaced = new StringBuilder();

        for (int i = 0; ;i++)
        {
            bool found = false;
            if (i==phrase2.Length)
            {
                break;
            }

            for (int j = 0; j < forbiddenWords.Length; j++)
            {
                if (phrase2[i] == forbiddenWords[j])
                {
                    replaced.Append(Regex.Replace(phrase2[i], forbiddenWords[j], replacements[j], RegexOptions.IgnorePatternWhitespace));
                    replaced.Append(' ');
                    found= true;
                    break;
                } 
            }

            if(found==false) { replaced.Append(phrase2[i] + " "); }
        }


        Console.WriteLine(replaced);

    }
}