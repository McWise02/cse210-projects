using System.Security.Cryptography;

public class JournalEntry
{
    public string _date { get; set; }
    public string _entry {get; set;}
    public string _prompt {get; set;}

    public JournalEntry()
    {

        _date = DateTime.Now.ToString("MM/dd/yyyy");
        _entry = "";
    
    }

    public void getEntry(string prompt)
    {
        Console.WriteLine(prompt);
        _prompt = prompt;
        _entry = Console.ReadLine();

    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Entry: {_entry}");
        Console.WriteLine();
    }
}