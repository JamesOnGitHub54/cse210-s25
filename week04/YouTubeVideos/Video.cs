public class Video
{
    public string _title;
    public string _author;
    public string _length;
    public List<Comment> _comments = new List<Comment>();

    public void Display()
    {
        // Present core video details.
        Console.WriteLine($"Title: {_title}\nAuthor: {_author}\nVideo length: {_length} seconds");
        // Iterate through each comment, formatted in the Comment file.
        foreach (Comment comment in _comments)
        {
            comment.Display();
        }
    }
}