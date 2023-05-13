using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    private static string[] prompts = new string[]
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };
    
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        bool running = true;
        
        while (running)
        {
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
            Console.WriteLine("Select an option: ");
            String optionAsString = Console.ReadLine();
            
            if (int.TryParse(optionAsString, out int option))
            {
                switch (option)
                {
                    case 1:
                        WriteNewEntry(journal);
                        break;
                    case 2:
                        journal.DisplayEntries();
                        break;
                    case 3:
                        SaveJournal(journal);
                        break;
                    case 4:
                        LoadJournal(journal);
                        break;
                    case 5:
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
    }
    
    private static void WriteNewEntry(Journal journal)
    {
        Random random = new Random();
        int index = random.Next(prompts.Length);
        string prompt = prompts[index];
        Console.WriteLine($"Prompt: {prompt}");
        Console.WriteLine("Your response: ");
        string response = Console.ReadLine();
        string date = DateTime.Now.ToString("yyyy-MM-dd");
        journal.AddEntry(new Entry(date, prompt, response));
    }
    
    private static void SaveJournal(Journal journal)
    {
        Console.Write("Enter filename to save: ");
        string filename = Console.ReadLine();
        
        if (!string.IsNullOrWhiteSpace(filename))
        {
            journal.SaveToFile(filename);
            Console.WriteLine("Journal saved successfully!");
        }
        else
        {
            Console.WriteLine("Invalid filename!");
        }
    }
    
    private static void LoadJournal(Journal journal)
    {
        Console.Write("Enter filename to load: ");
        string filename = Console.ReadLine();
        
        if (!string.IsNullOrWhiteSpace(filename))
        {
            journal.LoadFromFile(filename);
            Console.WriteLine("Journal loaded successfully!");
        }
        else
        {
            Console.WriteLine("Invalid filename!");
        }
    }
}
