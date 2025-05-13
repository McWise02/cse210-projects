using System;

class Program
{
    static void Main(string[] args)

    {
        Journal journal = new Journal();
        int number;
        do
        {
            Console.Write("Please select one of the following choices: \n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit\n");
            number = int.Parse(Console.ReadLine());

            if (number == 1)
            {
                journal.AddEntry();
            }
            else if (number == 2)
            {
                journal.Display();
            }
            else if (number == 3)
            {
                journal.Load();
            }
            else if (number == 4)
            {
                journal.Save();
            }
            else if (number == 5)
            {
                Console.WriteLine("Goodbye!");
                break;
            }
            else {
                Console.WriteLine("Invalid choice, please try again.");
            }
            

        } while (number != 0);
    }
}