public class Journal
{


    public string _name { get; set; }
    public List<JournalEntry> _entries = new List<JournalEntry>();

    public List<string> _prompts = new List<string>([
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        ]);
    public Journal()
    {
    }

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Entries:");
        foreach (JournalEntry entry in _entries)
        {
            entry.Display();
        }
    }

    public void AddEntry()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        string prompt = _prompts[index];
        _prompts.RemoveAt(index);
        JournalEntry entry = new JournalEntry();
        entry.getEntry(prompt);
        _entries.Add(entry);
    }
    public void Load()
    {
        Console.WriteLine("What file should I load?");
        string path = Console.ReadLine();

        if (!File.Exists(path))
        {
            Console.WriteLine("File not found.");
            return;
        }

        string[] lines = File.ReadAllLines(path);

        for (int i = 0; i < lines.Length;)
        {
            string date = lines[i++];
            string prompt = lines[i++];
            string entry = lines[i++];
            string separator = lines[i++];

            if (separator != "|||ENTRY_SEPARATOR|||")
            {
                Console.WriteLine("Houston, we have a problem");
                return;
            }

            JournalEntry je = new JournalEntry
            {
                _date = date,
                _prompt = prompt,
                _entry = entry
            };
            _entries.Add(je);
        }

        Console.WriteLine("Journal loaded.");
}

    public void Save()
{
    Console.WriteLine("What file should I save to?");
    string path = Console.ReadLine();
    using (StreamWriter writer = new StreamWriter(path))
    {
        foreach (JournalEntry entry in _entries)
        {
            writer.WriteLine(entry._date);
            writer.WriteLine(entry._prompt);
            writer.WriteLine(entry._entry);
            writer.WriteLine("|||ENTRY_SEPARATOR|||");
        }
    }
    Console.WriteLine("Journal saved.");
}

}