using System;

public class Word
{
    // The actual word text
    private string _text;
    // indicates whether word is hidden
    private bool _isHidden;

    // Constructor: Initializes a new Word object 
    // with the given text and sets it as visible
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    // Hides the word
    public void Hide()
    {
        _isHidden = true;
    }

    // shows the word
    public void show()
    {
        _isHidden = false;
    }

    // Returns true if the word is hidden
    public bool IsHidden()
    {
        return _isHidden;
    }

    // Returns either the word or underscore
    public string GetDisplayText()
    {
        if (_isHidden)
        {
            // Creates underscores matching word length
            return new string('_', _text.Length);
        }
        return _text;
    }
}