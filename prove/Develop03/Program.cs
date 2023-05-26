using System;

class Program
{
    static void Main(string[] args)
    {
        Reference ref1 = new Reference("Proverbs", 3, 5,6);
        KeyWords kw1 = new KeyWords("Trust");
        Scripture scr1 = new Scripture("5 Trust in the LORD with all thine heart; and lean not unto thine own understanding. \n6 In all thy ways acknowledge him, and he shall direct thy paths.");

        string keyword = kw1.returningKeyWord();
        string fullReference = ref1.returningString();
        string returningScripture = scr1.DisplayScripture();
        ScriptureMemorizer memorizer = new ScriptureMemorizer(scr1, fullReference);


        Console.WriteLine(keyword);
        Console.WriteLine(fullReference);
        Console.WriteLine(returningScripture);
        memorizer.MemorizeScripture();
        


    }
}