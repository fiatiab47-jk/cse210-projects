using System;

public class Assignment
{
    private string _studentName;
    private string _topic;

    // Constructor sets common values
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    // Getters to expose student and topic name to derived classes
    public string GetStudentName()
    {
        return _studentName;
    }

    public string GetTopic()
    {
        return _topic;
    }

    // Returns a summary used by all derived classes
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
}