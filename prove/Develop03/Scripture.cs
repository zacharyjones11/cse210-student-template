class Scripture
{
    private ScriptureReference reference;
    private List<Word> words;

    public bool AllHiddenWords 
    { 
        get 
        {
            return words.TrueForAll(w => w.IsHidden());
        } 
    }

    public Scripture(ScriptureReference reference, string text)
    {
        this.reference = reference;
        string[] wordArray = text.Split(' ');
        words = new List<Word>();
        
        foreach (string wordText in wordArray)
        {
            words.Add(new Word(wordText));
        }
    }

    public ScriptureReference GetReference()
    {
        return reference;
    }

    public void SetReference(ScriptureReference reference)
    {
        this.reference = reference;
    }

    public List<Word> GetWords()
    {
        return new List<Word>(words); // Return a copy to prevent direct modification
    }

    // Modified to hide just 1 word at a time
    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        
        List<int> unhiddenWordIndices = new List<int>();
        
        for (int i = 0; i < words.Count; i++)
        {
            if (!words[i].IsHidden())
            {
                unhiddenWordIndices.Add(i);
            }
        }

        if (unhiddenWordIndices.Count == 0)
        {
            return;
        }

        int randomIndex = random.Next(unhiddenWordIndices.Count);
        
        words[unhiddenWordIndices[randomIndex]].Hide();
    }

    public string GetDisplayText()
    {
        string displayText = reference.GetDisplayText() + "\n";
        
        foreach (Word word in words)
        {
            displayText += word.GetDisplayText() + " ";
        }
        
        return displayText.Trim();
    }
}