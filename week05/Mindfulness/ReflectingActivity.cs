public class ReflectionActivity : Activity {
    private List<string> _prompts;
    private List<string> _questions;
    private Random _random;

    public ReflectionActivity(string activityName, string activityDescription) : base(activityName, activityDescription) {
        _prompts = new List<string> {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };
        _questions = new List<string> {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you feel when it was complete?",
            "What is your favorite memory from this experience?"
        };
        _random = new Random();
    }

    public void Run() {
        DisplayStartingMessge();
        int rounds = _duration / 10;
        Console.WriteLine("You will have 10 seconds to think about the prompt.");
        Console.WriteLine(GetRandomPrompt());
        ShowCountdown(10);
        while (rounds > 0) {
            Console.WriteLine(GetRandomQuestion());
            ShowSpinner(10);
            rounds--;
        }
        
        DisplayEndingMessage();
    }

    private string GetRandomPrompt() {
        return _prompts[_random.Next(_prompts.Count)];
    }

    private string GetRandomQuestion() {
        return _questions[_random.Next(_questions.Count)];
    }
}