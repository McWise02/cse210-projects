public class Scripture
{
    private string _scriptureText;
    private Reference _reference;
    private List<Word> _words;
    private List<Word> _HiddenWords;
    private Random random;
    private bool _justStarted;
    public Scripture(string scriptureText, Reference reference)
    {
        _justStarted = true;
        _scriptureText = scriptureText;
        _reference = reference;
        _words = new List<Word>();
        _HiddenWords = new List<Word>();
        string[] wordsArray = scriptureText.Split(' ');
        foreach (string word in wordsArray)
        {
            _words.Add(new Word(word));
        }
        random = new Random();
    }

    public string GetScriptureText()
    {
        string scriptureText = "";

        if (!_justStarted)
        {
            int numberOfHiddenWords = random.Next(1, 4);
            int count = 0;

            while (count < numberOfHiddenWords)
            {
                int index = random.Next(0, _words.Count);
                if (count < numberOfHiddenWords && !_HiddenWords.Contains(_words[index]))
                {
                    _words[index].Hide();
                    _HiddenWords.Add(_words[index]);
                    count++;
                } else {
                    
                    if (CheckHiddenWords()) {
                        break;
                    }
                    continue;
                }
                
            }
            foreach (Word word in _words)
            {
                scriptureText += word.GetWord() + " ";
            }
            
            return scriptureText;
        } else {
            _justStarted = false;
            foreach (Word word in _words)
            {
                scriptureText += word.GetWord() + " ";
            }
            return scriptureText;
        }
    }

    public bool CheckHiddenWords() {
        if(_HiddenWords.Count == _words.Count){
            return true;
        } else {
            return false;
        }
    }

    public string GetReferenceText() {
        return _reference.GetReference();
    }
}