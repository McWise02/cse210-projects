using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();

        string choice = "";
        while (choice != "7")
        {
            manager.DisplayPlayerInfo();
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. List Goals");
            Console.WriteLine("2. Create New Goal");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Quit");

            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    manager.ListGoalDetails();
                    break;
                case "2":
                    manager.CreateGoal();
                    break;
                case "3":
                    manager.RecordEvent();
                    break;
                case "4":
                    manager.SaveGoals();
                    break;
                case "5":
                    manager.LoadGoals();
                    break;
                case "6":
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }}
