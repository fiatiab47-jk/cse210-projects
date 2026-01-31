using System;
using System.Collections.Generic;

// This class represents a YouTube video
public class Video
{
    public string _title;
    public string _author;
    public int _lengthInSeconds;
    // List of comments related to a video
    public List<Comment> _comments = new List<Comment>();

    public int GetNumberOfComments()
    {
        return _comments.Count;
    }
} 