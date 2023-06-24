using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

abstract class Goals
{
    protected int id;
    public static int totalPoints;

    public static int numberOfGoals = 0;

    public static List<Goals> goalsBeingCreated = new List<Goals>();

    public static int printId;

    public static string filePath;

    public static void SlashInCircling(int times)
    {
        for (int i = 0; i < times; i++)
        {
            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("—");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("|");
            Thread.Sleep(250);
            Console.Write("\b \b");
        }
    }

    public static void PrintingList()
    {
        GettingPointsfile();
        Console.WriteLine("The goals are: ");
        foreach (var item in goalsBeingCreated)
        {
            string check = "";

            if (item is SingleGoal singleGoal)
            {
                if (singleGoal.GetDid() == true)
                {
                    check = "[X]";
                }
                else
                {
                    check = "[ ]";
                }
                printId += 1;
                Console.WriteLine(printId + ". " + check + singleGoal.GetName() + " (" + singleGoal.GetDescription() + ")");
            }
            else if (item is EternalGoals eternalGoals)
            {
                if (eternalGoals.GetDid() == true)
                {
                    check = "[X]";
                }
                else
                {
                    check = "[ ]";
                }
                printId += 1;
                Console.WriteLine(printId + ". " + check + eternalGoals.GetName() + " (" + eternalGoals.GetDescription() + ")");

            }
            else if (item is ChecklistGoals checklistGoals)
            {
                if (checklistGoals.GetDid() == true)
                {
                    check = "[X]";
                }
                else
                {
                    check = "[ ]";
                }
                printId += 1;
                Console.WriteLine(printId + ". " + check + " " + checklistGoals.GetName() + " (" + checklistGoals.GetDescription() + ") " + "-- " + "Currently completed: " + checklistGoals.GetTimesDid() + "/" + checklistGoals.GetTimes());
            }
            Console.WriteLine("");
        }

        printId = 0;
        // Console.WriteLine("You have " + Goals.totalPoints + " points");
        SlashInCircling(5);
    }

    public Goals()
    {
        // Construtor da classe Goals
    }

    public static void SaveGoalsToFile()
    {
        Console.Write("What is the filename for the goal file? ");
        filePath = Console.ReadLine();

        int idToSave = 1; // Initialize the idToSave

        if (!File.Exists(filePath))
        {
            File.Create(filePath).Close();
        }

        // Find the last line in the file to determine the idToSave
        if (File.Exists(filePath))
        {
            using (StreamReader fileReader = new StreamReader(filePath))
            {
                string lastLine = null;
                string currentLine;

                while ((currentLine = fileReader.ReadLine()) != null)
                {
                    lastLine = currentLine;
                }

                if (lastLine != null)
                {
                    string[] goalData = lastLine.Split(new string[] { "//" }, StringSplitOptions.None);
                    if (goalData.Length > 0)
                    {
                        if (int.TryParse(goalData[0], out int lastId))
                        {
                            idToSave = lastId + 1;
                        }
                    }
                }
            }
        }

        using (StreamWriter writer = new StreamWriter(filePath, true))
        {
            foreach (var item in goalsBeingCreated)
            {
                string line = "";

                if (item is SingleGoal singleGoal)
                {
                    // Construct the line for SingleGoal
                    line += idToSave.ToString() + "//" + "SingleGoal" + "//" + singleGoal.GetName() + "//" + singleGoal.GetDescription() + "//" + singleGoal.GetDid() + "//" + singleGoal.GetPoints();
                }
                else if (item is EternalGoals eternalGoals)
                {
                    // Construct the line for EternalGoals
                    line += idToSave.ToString() + "//" + "EternalGoals" + "//" + eternalGoals.GetName() + "//" + eternalGoals.GetDescription() + "//" + eternalGoals.GetDid() + "//" + eternalGoals.GetPoints() + "//";
                }
                else if (item is ChecklistGoals checklistGoals)
                {
                    // Construct the line for ChecklistGoals
                    line += idToSave.ToString() + "//" + "ChecklistGoals" + "//" + checklistGoals.GetName() + "//" + checklistGoals.GetDescription() + "//" + checklistGoals.GetDid() + "//" + checklistGoals.GetPoints() + "//" + checklistGoals.GetTimes() + "//" + checklistGoals.GetTimesDid() + "//" + checklistGoals.GetExtraPoints();
                }

                writer.WriteLine(line); // Write the line to the file
                idToSave++; // Increment the idToSave for the next line
            }
        }

        Console.Clear();
        Console.WriteLine("Goals saved to file: " + filePath);
        SlashInCircling(3);
        goalsBeingCreated.Clear(); // Clear the list after saving
        Console.Clear();
    }

    public static void LoadingGoals()
    {
        Console.Clear();
        Console.Write("What is the filename for the goal file? ");
        filePath = Console.ReadLine();
    }

    public static void PrintingSavedGoals()
    {
        if (string.IsNullOrEmpty(filePath))
        {
            Console.WriteLine("You haven't selected a file or input any goals. Please load a file using the fourth option in the menu.");
            return;
        }
        else
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;

                Console.WriteLine("The goals are:");
                Console.WriteLine("");

                while ((line = reader.ReadLine()) != null)
                {
                    string[] goalData = line.Split(new string[] { "//" }, StringSplitOptions.None);

                    if (goalData[1] == "SingleGoal" || goalData[1] == "EternalGoals")
                    {
                        if (goalData[4] == "true")
                        {
                            Console.WriteLine(goalData[0] + ". " + "[x] " + goalData[1] + " (" + goalData[2] + ")");
                        }
                        else
                        {
                            Console.WriteLine(goalData[0] + ". " + "[ ] " + goalData[1] + " (" + goalData[2] + ")");
                        }
                        printId += 1;
                    }
                    else if (goalData[1] == "ChecklistGoals")
                    {
                        if (goalData[4] == "true")
                        {
                            Console.WriteLine(goalData[0] + ". " + "[x] " + goalData[1] + " (" + goalData[2] + ") " + "-- Currently completed: " + goalData[7] + "/" + goalData[6]);
                        }
                        else
                        {
                            Console.WriteLine(goalData[0] + ". " + "[ ] " + goalData[1] + " (" + goalData[2] + ") " + "-- Currently completed: " + goalData[7] + "/" + goalData[6]);
                        }
                    }
                }
            }
        }
    }

    public static void RecordingEvent()
    {
        Console.Clear();

        if (string.IsNullOrEmpty(filePath))
        {
            Console.WriteLine("You haven't selected a file or input any goals. Please load a file using the fourth option in the menu.");
            return;
        }

        Console.WriteLine("The goals are:");
        Console.WriteLine("");

        // Read the file and display the goals
        using (StreamReader reader = new StreamReader(filePath))
        {
            string line;

            while ((line = reader.ReadLine()) != null)
            {
                string[] goalData = line.Split(new string[] { "//" }, StringSplitOptions.None);
                Console.WriteLine(goalData[0] + ". " + goalData[1]);
            }
        }

        Console.Write("Which goal did you accomplish? ");
        string numberOfAccomplishedGoal = Console.ReadLine();

        // Modify the file and update the goal's data
        List<string> updatedLines = new List<string>();

        using (StreamReader reader = new StreamReader(filePath))
        {
            string line;

            while ((line = reader.ReadLine()) != null)
            {
                string[] goalData = line.Split(new string[] { "//" }, StringSplitOptions.None);

                if (goalData[0] == numberOfAccomplishedGoal)
                {
                    goalData[4] = "true";

                    int points = 0;
                    if (int.TryParse(goalData[5], out points))
                    {
                        // Goals.totalPoints += points;
                        UpdatePoints(points);
                    }

                    line = string.Join("//", goalData);
                }

                if (goalData[1] == "ChecklistGoals")
                {
                    int numberOfDid;
                    if (int.TryParse(goalData[7], out numberOfDid)){
                        numberOfDid += 1;
                        goalData[7] = numberOfDid.ToString();
                        int timesToComplete;
                        if (int.TryParse(goalData[6], out timesToComplete) && numberOfDid == timesToComplete){
                            int extraPoints;
                            if (int.TryParse(goalData[8], out extraPoints)){
                                // Goals.totalPoints += extraPoints;
                                UpdatePoints(extraPoints);
                                goalData[7] = "0";
                            }
                        }
                    }
                    else
                    {
                        goalData[7] = numberOfDid.ToString();
                    }
                }

                line = string.Join("//", goalData);
                updatedLines.Add(line); // Adicionar a linha atualizada à lista
            }
        }

        // Save the modified lines back to the file
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            foreach (string eachLine in updatedLines)
            {
                writer.WriteLine(eachLine);
            }
        }

        Console.Clear();
        Console.WriteLine("Goal updated successfully!");
        SlashInCircling(3);
        Console.Clear();
    }
    public static void UpdatePoints(int pointsToAdd)
    {
        string pointsFilePath = "points.txt";
        int currentPoints = 0;

        // Read the current points from the file
        if (File.Exists(pointsFilePath))
        {
            using (StreamReader reader = new StreamReader(pointsFilePath))
            {
                string pointsStr = reader.ReadLine();
                if (!int.TryParse(pointsStr, out currentPoints))
                {
                    Console.WriteLine("Invalid points data in the file. Please make sure the file contains a valid integer value.");
                    return;
                }
            }
        }

        // Calculate the updated points
        int updatedPoints = currentPoints + pointsToAdd;

        // Write the updated points back to the file, replacing the previous value
        using (StreamWriter writer = new StreamWriter(pointsFilePath, false))
        {
            writer.WriteLine(updatedPoints);
        }

        Console.WriteLine("Points updated successfully!");
        SlashInCircling(2);
    }



    public static void GettingPointsfile()
    {
        string pointsFilePath = "points.txt";
        int currentPoints;

        using (StreamReader reader = new StreamReader(pointsFilePath))
        {
            string pointsStr = reader.ReadLine();
            currentPoints = int.Parse(pointsStr);
        }
        // Set the totalPoints value to the current points
        Goals.totalPoints = currentPoints;
        Console.WriteLine("You have " + Goals.totalPoints + " points");
        SlashInCircling(2);
        
    }


}
