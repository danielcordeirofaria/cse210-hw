class Reference
{
    private string _book;
    private int _chapter;
    private int _initialVerse;
    private int _finalVerse;

    public Reference(string book, int chapter, int initialVerse, int finalVerse)
    {
        _book = book;
        _chapter = chapter;
        _initialVerse = initialVerse;
        _finalVerse = finalVerse;
    }

    public Reference(string book, int chapter, int initialVerse)
    {
        _book = book;
        _chapter = chapter;
        _initialVerse = initialVerse;
        _finalVerse = 0;
    }

    public string GetBook()
    {
        return _book;
    }

    public int GetChapter()
    {
        return _chapter;
    }

    public int GetInitialVerse()
    {
        return _initialVerse;
    }

    public int GetFinalVerse()
    {
        return _finalVerse;
    }

    public string returningString()
    {
        if (_finalVerse == 0)
        {
            return $"{_book} {_chapter}:{_initialVerse} ";
        }
        else
        {
            return $"{_book} {_chapter}:{_initialVerse}-{_finalVerse} ";
        }
    }
}
