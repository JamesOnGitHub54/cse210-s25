public class Video
{
    public string _title;
    public string _author;
    public string _length;
    public string _comment_number;
    public List<Comment> _comments = new List<Comment>();

// Gets the number of comments for a video
    public string Number()
    {
        // Iterate through each comment, adding to the total number of comments.
        foreach (Comment comment in _comments)
        {
            _comment_number += 1;
        }
        // Learned Convert.ToString() via W3Schools: https://www.w3schools.com/cs/cs_type_casting.php
        Convert.ToString(_comment_number);
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