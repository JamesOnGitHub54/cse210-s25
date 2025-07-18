public class Video
{
    public string _title;
    public string _author;
    public string _length;
    public int _comment_number;
    public List<Comment> _comments = new List<Comment>();

// Gets the number of comments for a video
    public int Number()
    {
        // Iterate through each comment, adding to the total number of comments.
        foreach (Comment comment in _comments)
        {
            _comment_number += 1;
        }
        return _comment_number;
    }

    public void Display()
    {
        // Present core video details.
        Console.WriteLine($"Title: {_title}\nAuthor: {_author}\nVideo length: {_length} seconds\nNumber of comments: {_comment_number}");
        // Iterate through each comment, formatted in the Comment file.
        foreach (Comment comment in _comments)
        {
            comment.Display();
        }
    }
}