public class ListingActivity : Activity {
    private int _count;
    private List<string> _prompts = new List<string> {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "What is something you have done recently to help yourself?",
        "What is your favorite thing about yourself?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    private List<String> _usedPrompts = new List<string>();
    private Random _random = new Random();

    public ListingActivity(string activityName, string activityDescription) : base(activityName, activityDescription) {
        _count = 0;
    }

    public void Run() {
        DisplayStartingMessge();
        int rounds = _duration / 25;
        while (rounds == 0) {
            Console.WriteLine("You need to set the duration to at least 25 seconds.\nEnter a new duration: ");
            _duration = int.Parse(Console.ReadLine());
            rounds = _duration / 25;
        }
        
        while (rounds > 0) {
            Console.WriteLine("Press enter when you are ready for the prompts. You will have 10 Seconds for each prompt.");
            Console.ReadLine();
            int index = 0;
            while (index < _prompts.Count) {
                DisplayRandomPrompt();
                index++;
                DateTime startTime = DateTime.Now;
                DateTime endTime = startTime.AddSeconds(10);
                List<string> responses = new List<string>();
                while (DateTime.Now < endTime) {
                    Console.Write("Enter your response: ");
                    string response = Console.ReadLine();
                    responses.Add(response);
                }
                Console.WriteLine($"You have entered {responses.Count} responses.");
            }
            rounds--;
        }
        
        DisplayEndingMessage();
        
    }

    public void DisplayRandomPrompt() {
        if (_prompts.Count == 0) {
            Console.WriteLine("No more prompts available.");
            return;
        }
        int index = _random.Next(_prompts.Count);
        string prompt = _prompts[index];
        _prompts.RemoveAt(index);
        _usedPrompts.Add(prompt);
        Console.WriteLine(prompt);
        ShowCountdown(5);
    }
}