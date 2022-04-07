class Exercise3
{
    static void Main()
    {
        int count = 0;
        char outlier=' ';
        Console.Write("Please enter an arithmetic expression ontaining parentheses: ");
        string arthExp = Console.ReadLine();

        for(int i = 0; i < arthExp.Length; i++)
        {
            if(arthExp[i] == '(')
            {
                count++;
            }

            else if(arthExp[i] == ')')
            {
                count--;
            }
        }

        if (count < 0 || count > 0)
        {
            if (count < 0) { outlier = ')'; }
            else if (count > 0) { outlier = '('; }
            Console.WriteLine("The expression entered has {0} extra \'{1}\'s ",(Math.Abs(count)), outlier);
        }

        else if (count == 0)
        {
            Console.WriteLine("The expression entered has the right number of parentheses");
        }
    }
}