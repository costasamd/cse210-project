using System.Diagnostics.Metrics;

public class Video
{
    public string _title;
    public string _author;
    public int _length;

    public List<Comment> _comments = new();

    public void Display()
    {
        Console.WriteLine($"The Video Title: {_title}\nThe Video Author: {_author}\nThe Video Length: {_length}seconds\nNumber of comments in this video: {CountComments()}");

        foreach (Comment line in _comments)
        {
            line.Display();
        }
    }

    public void AddComment(Comment newComment)
    {
        _comments.Add(newComment);
    }

    public int CountComments()
    {

        var numberComments = _comments.Count;

        return numberComments;
    }

    
}