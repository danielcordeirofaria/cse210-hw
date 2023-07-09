class Comment
{
    private string _name;
    private string _commentText;

    public Comment(string name, string commentText)
    {
        _name = name;
        _commentText = commentText;
    }

    public String GetName(){
        return _name;
    }

    public String GetCommentText(){
        return _commentText;
    }

}
