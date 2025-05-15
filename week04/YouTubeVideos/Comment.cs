public class Comment {
    private string _commenter;
    private string _text;
    private DateTime _date;

    public Comment(string commenter, string text, DateTime date) {
        _commenter = commenter;
        _text = text;
        _date = date;
    }

    public string GetComment() {
        return $"{_commenter} ({_date.ToString("MM/dd/yyyy h:mm:ss tt")}): {_text}";
    }
}