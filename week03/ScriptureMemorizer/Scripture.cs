using System;
using System.Collections.Generic;

public class Scripture
{
    // The Scripture reference (Objection Composition)
    private Reference _reference;
    // Stores all words as objects
    private List<Word> _words;

    // Constructor receives reference and text
    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        // Remove line breaks and extra spaces
        text = text.Replace("\r", " ")
                   .Replace("\n", " ");

        // Creates empty list
        _words = new List<Word>();
        // Splits scripture text into words 
        foreach (string word in text.Split(" ", StringSplitOptions.RemoveEmptyEntries))
        {
            // Converts each string into a new Word Object
            _words.Add(new Word(word));
        }
    }

    // Hides a given number of words randomly
    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();

        int hiddenCount = 0;
        int attempts = 0;

        while (hiddenCount < numberToHide && attempts < _words.Count * 2)
        {
            int index = random.Next(_words.Count);
            if (!_words[index].IsHidden())
            {
                // Tells the Word to hide itself
                _words[index].Hide();
                hiddenCount++;
            }
            attempts++;
        }
    }


    // Check if all words are hidden
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }


    // Returns the formatted scripture text with some words hidden 
    public string GetDisplayText()
    {
        string text = _reference.GetDisplayText() + " ";

        foreach (Word word in _words)
        {
            text += word.GetDisplayText() + " ";
        }
        return text.Trim();
    }
}