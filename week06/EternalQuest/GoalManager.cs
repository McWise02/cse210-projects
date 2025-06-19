using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public GoalManager() { }

    public void Start()
    {
        Console.WriteLine("Welcome to Eternal Quest!");
        Console.WriteLine($"Your current score is: {_score}");
    }

    public void DisplayPlayerInfo()
    {
        _score = 0;
        foreach (Goal goal in _goals)
        {
            _score += goal._score;

        }
        Console.WriteLine($"Current Score: {_score}");
    }

    public void ListGoalNames()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("Current Goals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("What type of goal would you like to create?");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Enter choice (1-3): ");
        string choice = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();
        Console.Write("Enter goal points: ");
        int points = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case "1":
                _goals.Add(new SimpleGoal(name, description, points));
                break;
            case "2":
                _goals.Add(new EternalGoal(name, description, points));
                break;
            case "3":
                Console.Write("Enter target count: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points: ");
                int bonus = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }

    public void RecordEvent()
    {
        Console.WriteLine("Which goal did you accomplish?");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }

        Console.Write("Enter goal number: ");
        int goalIndex = int.Parse(Console.ReadLine()) - 1;

        if (goalIndex >= 0 && goalIndex < _goals.Count)
        {
            _goals[goalIndex].RecordEvent();
            _score += _goals[goalIndex]._points; // Assumes _points is accessible
        }
        else
        {
            Console.WriteLine("Invalid goal number.");
        }
    }



    public void SaveGoals()
    {
         _score = 0;
        foreach (Goal goal in _goals)
        {
            _score += goal._score;
        }
        Console.Write("Enter filename to save: ");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.WriteLine("Goals saved.");
    }

    public void LoadGoals()
    {
        Console.Write("Enter filename to load: ");
        string filename = Console.ReadLine();
        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);
            _score = int.Parse(lines[0]);

            _goals.Clear();

            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i];
                string[] parts = line.Split(':');
                string type = parts[0];
                string data = parts[1];
                switch (type)
                {
                    case "SimpleGoal":

    
                        _goals.Add(SimpleGoal.CreateFromString(data));
                        break;
                    case "EternalGoal":

                        _goals.Add(EternalGoal.CreateFromString(data));
                        break;
                    case "ChecklistGoal":
                        _goals.Add(ChecklistGoal.CreateFromString(data));
                        break;
                }
            }

            Console.WriteLine("Goals loaded.");
            
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }}
