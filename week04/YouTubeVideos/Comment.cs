using System;

public class Comment
{
    private string _name;
    private string _commentText;
    private DateTime _commentDate;

    public Comment(string name, string text)
    {
        _name = name;
        _commentText = text;
        _commentDate = DateTime.Now;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetText()
    {
        return _commentText;
    }

    public DateTime GetCommentDate()
    {
        return _commentDate;
    }
}
