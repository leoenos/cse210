using System;
using System.Reflection.Metadata;

public class Comment
{
    private string _user;
    private string _text;

    public Comment(string user, string text)
    {
        _user = user;
        _text = text;
    }

    public string GetUserName()
    {
        return _user;
    }

    public string GetComment()
    {
        return _text;
    }
}