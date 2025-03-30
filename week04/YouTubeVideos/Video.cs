using System;
using System.Collections.Generic;

public class Video
{
    private string _title;
    private string _author;
    private double _length;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, double length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public Video(string title, string author, double length, Comment comment)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments.Add(comment);
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public string GetTitle()
    {
        return _title;
    }

    public string GetAuthor()
    {
        return _author;
    }

    public double GetLength()
    {
        return _length;
    }

    public string GetVideoInfo()
    {
        string videoInfo = "";
        videoInfo += $"Title: {_title}\n";
        videoInfo += $"Author: {_author}\n";
        videoInfo += $"Length: {_length} seconds\n";
        videoInfo += $"Number of Comments: {GetNumberOfComments()}\n";
        videoInfo += $"Comments:\n";

        foreach (Comment comment in _comments)
        {
            videoInfo += $"- {comment.GetName()}: {comment.GetText()}\n";
        }
        return videoInfo; 
    }

    // Method to return the number of comments
    public int GetNumberOfComments()
    {
        int numberOfComments = 0;

        foreach (Comment comment in _comments)
        {
            numberOfComments++;
        }
        return numberOfComments;
    }
}

