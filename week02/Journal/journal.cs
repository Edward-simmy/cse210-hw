
using System.IO;

using System;
public class journal
{
    static void Main(string[] args)
       {
        //Creates a new instance of Journal
        journal journal = new journal();
        DateTime theCurrentTime = DateTime.Now;

        //Welcome banner
        Console.WriteLine("Welcome to Your Daily Journal!");
    
        while (true) {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Add Entry");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            //Requests user selection for action to take
            Console.Write("Please select an option (1-5) ");
            string choice = Console.ReadLine();

            //Calls class methods per user selection
            switch (choice) {
                //Adds new entry
                case "1":
                journal.AddEntry();
                break;

                //Displays added entries
                case "2":
                journal.isplayEntries();
                break;

                //Loads entries from a file
                case "3":
                journal.LoadFromFile();
                break;

                //Saves entries to a file
                case "4":
                journal.SaveToFile();
                break;

                //Exits program
                case "5":
                Console.WriteLine($"{DateTime.Now} Goodbye!");
                return;

                
                default:
                Console.WriteLine($"{DateTime.Now} Invalid selection, please enter a number 1-5.");
                break;
            }
        }
    }
}