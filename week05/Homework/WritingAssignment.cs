public class WritingAssignment : Assignment{
    private string _title;
    private string _author;

    public WritingAssignment(string studentName, string topic, string title, string author) : base(studentName, topic) {
        _title = title;
        _author = author;
    }

    public string GetWritingInformation() {
        return $"Title: {_title} by {_author}";
    }
}