using System;

class ScriptureMemorizer
{
    private Scripture _scripture;
    private string[] _wordsToHide;
    private int _wordIndex;
    private Random _random;
    private string _fullReference; 

    public ScriptureMemorizer(Scripture scripture, string fullReference) 
    {
        _scripture = scripture;
        _wordsToHide = _scripture.GetWords();
        _wordIndex = 0;
        _random = new Random();
        _fullReference = fullReference; 
    }

    public void MemorizeScripture()
    {
        Console.WriteLine("Press Enter to hide a word or type 'quit' to exit.");

        while (_wordIndex < _wordsToHide.Length) 
        {
            string input = Console.ReadLine();

            if (input == "quit")
            {
                break;
            }

            HideWord();
            _wordIndex++;
        }

        Console.WriteLine("All words have been hidden.");
    }

    private void HideWord()
    {
        int randomIndex = _random.Next(_wordsToHide.Length - _wordIndex);
        string wordToHide = _wordsToHide[randomIndex];
        string hiddenWord = new string('_', wordToHide.Length);

        _scripture.ReplaceWord(wordToHide, hiddenWord);
        Console.Clear(); 
        Console.WriteLine(_fullReference); 
        Console.WriteLine(_scripture.DisplayScripture());

        _wordsToHide[randomIndex] = _wordsToHide[_wordsToHide.Length - _wordIndex - 1];
    }
}
