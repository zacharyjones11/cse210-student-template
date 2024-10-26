class Word
{
    private string _wordText;
    public bool _isHidden;


    public Word(string text)
    {
        _wordText = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public string GetDisplayText()
    {
        // If hidden, show underscores; if not, show the word
        return _isHidden ? new string('_', _wordText.Length) : _wordText;
    }
}