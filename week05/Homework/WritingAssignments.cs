public class Writing : Assignment
{
    private string _title;
    public Writing(string studentName, string subject, string title) : base(studentName, subject)
    {
        _title = title;
    }

    public string GetWriting()
    {
        string studentName = GetStudentName();

        return $"{_title} by {studentName}";
    }
}