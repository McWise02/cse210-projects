public class Word{
    private string _word;
    private bool _isHidden = false;

    public Word(string word) {
        _word = word;
        _isHidden = false;
    }

    public string GetWord() {
        if (_isHidden) {
            return new string('_', _word.Length);
        } else {
            return _word;
        }
    }
    public void Hide() {
        _isHidden = true;
    }
}