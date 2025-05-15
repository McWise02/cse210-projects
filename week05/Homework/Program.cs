using System;

class Program
{
    static void Main(string[] args)
    {
        WritingAssignment assignment = new WritingAssignment("John Doe", "English Learning", "The Great Gatsby", "The Big Boss");
        Console.WriteLine(assignment.GetSummary());
        Console.WriteLine(assignment.GetWritingInformation());
    }
}