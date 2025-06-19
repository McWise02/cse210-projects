public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    public int _points;

    public int _score;
    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
        _score = 0;
    }

    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetDetailsString();
    public abstract string GetStringRepresentation();

    public int GetScore()
    {
        return _score;
    }
}
