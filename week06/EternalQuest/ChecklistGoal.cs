public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    
    }

    public override void RecordEvent()
    {
        _score += _points;
        _amountCompleted++;
        Console.WriteLine($"You earned {_points} points!");

        if (IsComplete())
        {
            _score += _bonus;
            Console.WriteLine($"Congratulations! You completed the goal and earned a bonus of {_bonus} points!");
        }
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        string status = IsComplete() ? "X" : " ";
        return $"[{status}] {_shortName} ({_description}) -- Completed {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_shortName},{_description},{_points},{_bonus},{_target},{_amountCompleted}";
    }

    public static ChecklistGoal CreateFromString(string data)
    {
        string[] parts = data.Split(',');
        string name = parts[0];
        string desc = parts[1];
        int points = int.Parse(parts[2]);
        int bonus = int.Parse(parts[3]);
        int target = int.Parse(parts[4]);
        int completed = int.Parse(parts[5]);

        ChecklistGoal goal = new ChecklistGoal(name, desc, points, target, bonus);
        goal._amountCompleted = completed;
        goal._score = points * completed;
        if (goal.IsComplete())
        {
            goal._score += bonus;
        }
        return goal;
    }
}
