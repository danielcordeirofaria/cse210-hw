 class Scripture
{

    private string _text;
     public Scripture(string text)
    {
        _text = text;

    }

     public string[] GetWords()
    {
        char[] delimiters = {' '};
        string[] words = _text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
        return words;
    }

    public void ReplaceWord(string wordToReplace, string replacement)
    {
        _text = _text.Replace(wordToReplace, replacement);
    }


     public String DisplayScripture()
    {
        string[] words = _text.Split(' ');

        string scriptureText = string.Join(" ", words);

        return scriptureText;
    }


}