public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }

    public override void RecordEvent()
    {
        _score += _points;
        Console.WriteLine($"You earned {_points} points!");
    }

    public override bool IsComplete()
    {
        return false; // Never complete
    }

    public override string GetDetailsString()
    {
        return $"[∞] {_shortName} ({_description})";
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{_shortName},{_description},{_points},{_score}";
    }

    public static EternalGoal CreateFromString(string data)
    {
        string[] parts = data.Split(',');
        string name = parts[0];
        string desc = parts[1];
        int points = int.Parse(parts[2]);
        int score = int.Parse(parts[3]);
        EternalGoal goal = new EternalGoal(name, desc, points);
        goal._score = score; // Set the score from the string data
        return goal;
    }
}
