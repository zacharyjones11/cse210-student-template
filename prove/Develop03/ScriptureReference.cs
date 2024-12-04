class ScriptureReference
{
    private string _book;
    private int _chapter;
    private int _verse;

    public ScriptureReference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public string GetBook()
    {
        return _book;
    }

    public void SetBook(string book)
    {
        _book = book;
    }

    public int GetChapter()
    {
        return _chapter;
    }

    public void SetChapter(int chapter)
    {
        _chapter = chapter;
    }

    public int GetVerse()
    {
        return _verse;
    }

    public void SetVerse(int verse)
    {
        _verse = verse;
    }

    public string GetDisplayText()
    {
        return $"{_book} {_chapter}:{_verse}";
    }
}