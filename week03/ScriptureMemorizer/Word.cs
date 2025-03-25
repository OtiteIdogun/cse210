using System;

public class Word
{
    private string _wordText;
    private bool _isHidden;

    public Word(string wordText)
    {
        _wordText = wordText;
        _isHidden = false; // Means word is not hidden but visible by default
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        return _isHidden ? new string('_', _wordText.Length) : _wordText;
    }
}
