class Word
{
    private string _wordText;
    private bool _isHidden;

    public Word(string text)
    {
        _wordText = text;
        _isHidden = false;
    }

    public string GetWordText()
    {
        return _wordText;
    }

    public void SetWordText(string text)
    {
        _wordText = text;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public void SetHidden(bool hidden)
    {
        _isHidden = hidden;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public string GetDisplayText()
    {
        return _isHidden ? new string('_', _wordText.Length) : _wordText;
    }
}