class ScriptureReference
{
    public string _book { get; private set; }
    public int _chapter { get; private set; }
    public int _verse { get; private set; }

    public ScriptureReference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;

        
    }

    public string GetDisplayText()
    {
        return $"{_book} {_chapter}:{_verse}";
    }
}