using System;

class Scripture
{
    public ScriptureReference _reference {get; private set; }
    public List<Word> _words = new();

    public bool AllHiddenWords => _words.All(w => w._isHidden);

    public Scripture(ScriptureReference reference, string text)
    {
        _reference = reference;
        string[] wordArray = text.Split(' ');
        _words = new List<Word>();
        
        foreach (string wordText in wordArray)
        {
            _words.Add(new Word(wordText));
        }
    }

    // Simplified HideRandomWords method
    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        
        // Create a list of indices for words that aren't hidden
        List<int> unhiddenWordIndices = new List<int>();
        
        // Find all unhidden words
        for (int i = 0; i < _words.Count; i++)
        {
            if (!_words[i]._isHidden)
            {
                unhiddenWordIndices.Add(i);
            }
        }

        // Determine how many words to hide
        int wordsToHide = numberToHide;
        if (wordsToHide > unhiddenWordIndices.Count)
        {
            wordsToHide = unhiddenWordIndices.Count;
        }

        // Hide random words
        for (int i = 0; i < wordsToHide; i++)
        {
            if (unhiddenWordIndices.Count == 0)
            {
                break;
            }

            // Get a random index from our list of unhidden word indices
            int randomIndex = random.Next(unhiddenWordIndices.Count);
            
            // Hide the word at this position
            _words[unhiddenWordIndices[randomIndex]].Hide();
            
            // Remove this index from our list
            unhiddenWordIndices.RemoveAt(randomIndex);
        }
    }

    public string GetDisplayText()
    {
        string displayText = _reference.GetDisplayText() + "\n";
        
        foreach (Word word in _words)
        {
            displayText += word.GetDisplayText() + " ";
        }
        
        return displayText.Trim();
    }
}