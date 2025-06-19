public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
        _score += _points; // Assuming _score is accessible
        Console.WriteLine($"You earned {_points} points!");
    }
    public override bool IsComplete()
    {
        return _isComplete;
}

    public override string GetDetailsString()
    {
        return $"[{(_isComplete ? "X" : " ")}] {_shortName} ({_description})";
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{_shortName},{_description},{_points},{_isComplete}";
    }

    public static SimpleGoal CreateFromString(string data)
    {
        string[] parts = data.Split(',');
        string name = parts[0];
        string desc = parts[1];
        int points = int.Parse(parts[2]);
        bool complete = bool.Parse(parts[3]);

        SimpleGoal goal = new SimpleGoal(name, desc, points);
        goal._isComplete = complete;
        if (goal.IsComplete())
        {
            goal._score += points; // If complete, add points to score
        } else
        {
            goal._score = 0; // If not complete, score is zero
        }
        return goal;
    }
}
