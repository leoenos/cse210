public class Math : Assignment
{
    private string _textbookSection;
    private string _problems;

    public Math(string studentName, string subject, string textbookSection, string problems) : base(studentName, subject)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    public string GetHomework()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }
}