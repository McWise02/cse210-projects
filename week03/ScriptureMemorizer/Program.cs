using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Scripture Memorizer!");
        Console.WriteLine("Plase enter a scripture reference:");
        string reference = Console.ReadLine();
        string[] wordsArray = reference.Split(' ');
        string bookName;

        Reference referenceobj;
        if (int.TryParse(wordsArray[0], out int bookNumber))
        {
            // e.g. "2 Nephi"
            bookName = wordsArray[0] + " " + wordsArray[1];
            reference = reference.Remove(0,2);
            
            wordsArray = reference.Split(' ');
        }
        else
        {
            // e.g. "Alma"
            bookName = wordsArray[0];
            
        }
        
        string[] chapter = wordsArray[1].Split(":");
        
        string verse = chapter[1];
        if (verse.Contains('-')){
            string[] verseRange = verse.Split('-');
            int startVerse = int.Parse(verseRange[0]);
            int endVerse = int.Parse(verseRange[1]);
            referenceobj = new Reference(bookName, int.Parse(chapter[0]), startVerse, endVerse);
            } else {
               referenceobj = new Reference(bookName, int.Parse(chapter[0]), int.Parse(verse)); 
            }
        
        Console.WriteLine("Please enter the scripture text:");
        string text = Console.ReadLine();
        Scripture scripture = new Scripture(text, referenceobj);
        while (scripture.CheckHiddenWords() != true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetReferenceText() + ' '  + scripture.GetScriptureText());
            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit.");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "quit")
            {
                return;
            }

            scripture.GetScriptureText();
        } 
        Console.Clear();
        Console.WriteLine(scripture.GetReferenceText() + ' '  + scripture.GetScriptureText());
        return;
    }
}