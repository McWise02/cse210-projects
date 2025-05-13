 public class Job
{
    public string _jobTitle { get; set; }
    public string _company { get; set; }
    public string _startYear { get; set; }
    public string _endYear { get; set; }

    public Job()
    {
    }
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear} - {_endYear}");
    }
}
