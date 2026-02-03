using System;

public class WritingAssignment : Assignment
{
    private string _title;

    // Constructor calls Assignment constructor for shared fields
    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }

    // Use base getter instead of direct access
    public string GetWritingInfo()
    {
        return $"{_title} by {GetStudentName()}";
    }
}