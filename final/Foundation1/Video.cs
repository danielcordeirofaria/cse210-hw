using System;
using System.Collections.Generic;

class Video
{
    private string _title;
    private string _author;
    private int _length;
    private string _link;
    private List<Comment> _comments;

    public Video(string title, string author, string link, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _link = link;
        _comments = new List<Comment>();
    }

    public void AddComment(string name, string text)
    {
        Comment comment = new Comment(name, text);
        _comments.Add(comment);
    }

    public int GetNumberOfComments(){
        return _comments.Count;
    }

    public string GetTitle()
    {
        return _title;
    }

    public string GetAuthor()
    {
        return _author;
    }

    public string GetLink()
    {
        return _link;
    }

    public int GetLenth()
    {
        return _length;
    }
    
    public void DisplayVideosDetails()
    {
        Console.WriteLine("Title: " + GetTitle() + "\nAuthor: " + GetAuthor() + "\nLength: " + GetLenth() + " seconds" + "\nAccess link: " + GetLink() + "\nNumber of Comments: " + GetNumberOfComments() + "\nComments:");

        foreach (Comment comment in _comments)
        {
            Console.WriteLine("Commenter: " + comment.GetName() + "\nText: " + comment.GetCommentText());
            Console.WriteLine();
        }
    }
}
