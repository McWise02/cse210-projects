using System;
public class Activity {
    private string _name;
    private string _description;
    protected int _duration;

    public Activity(string name, string description) {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessge() {
        Console.WriteLine($"Welcome to the {_name} activity.");
        Console.WriteLine(_description);
        Console.WriteLine($"How long in seconds would you like to do this activity?");
        _duration = int.Parse(Console.ReadLine());
    }

    public void DisplayEndingMessage() {
        Console.WriteLine($"Well done! You have completed the {_name} activity.");
    }

    public void ShowSpinner(int seconds) {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        string[] spinner = { "|", "/", "-", "\\" };

        while (DateTime.Now < endTime) {
            foreach (string s in spinner) {
                Console.Write(s);
                Thread.Sleep(250);
                Console.Write("\b \b");
            }
        }
        Console.WriteLine();
    }

    public void ShowCountdown(int seconds) {
        for (int i = seconds; i > 0; i--) {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b\b  \b\b");
        }
        Console.WriteLine();
    }
}