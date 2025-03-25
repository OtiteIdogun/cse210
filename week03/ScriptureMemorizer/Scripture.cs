using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string scriptureText)
    {
        _reference = reference;
        _words = new List<Word>();
        foreach (string word in scriptureText.Split(' '))
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberOfWordsToHide)
    {
        Random random = new Random();
        int numberOfHiddenWordsCounted = 0;
        while (numberOfHiddenWordsCounted < numberOfWordsToHide)
        {
            int index = random.Next(_words.Count);
            // Check if the word at the random index is not already hidden
            if (!(_words[index].IsHidden()))
            {
                _words[index].Hide();
                numberOfHiddenWordsCounted++;
            }
        }
    }

    public string GetDisplayText()
    {
        List<string> displayedWordsOfScripture = new List<string>();
        foreach (Word word in _words)
        {
            displayedWordsOfScripture.Add(word.GetDisplayText());
        }
        return $"{_reference.GetDisplayText()}\n" + string.Join(" ", displayedWordsOfScripture);
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false; // At least one word is still visible
            }
        }
        return true; // All words are hidden
    }
}
 