using System;                      // Allows basic system functionality
using System.Collections.Generic;  // Allows use of List<T>
using System.IO;                   // Allows file reading and writing   

public class GoalManager
{
    private List<Goal> _goals;  // List of all goals
    private int _score;         // Player score

    public GoalManager()
    {
        _goals = new List<Goal>();  // Initialize empty list
        _score = 0;                 // Start score at zero
    }
    
    // Display initial score
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"\nYou have {_score} points.");
        
    }

    public void Start()
    {
        int choice = 0;

        while (choice != 6)
        {
            DisplayPlayerInfo();
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");

            Console.Write("Select a choice from the menu: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1: CreateGoal(); break;
                case 2: ListGoalDetails(); break;
                case 3: SaveGoals(); break;
                case 4: LoadGoals(); break;
                case 5: RecordEvent(); break;
            }
        }
    }


    public void CreateGoal()
    {
        Console.WriteLine("\nThe types of Goal are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        Console.Write("Which type of goal would you like to create? ");
        int type = int.Parse(Console.ReadLine());

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with goal? ");
        int points = int.Parse(Console.ReadLine());

        if (type == 1)
        {
            _goals.Add(new SimpleGoal(name, description, points));
        }
        else if (type == 2)
        {
            _goals.Add(new EternalGoal(name, description, points));
        }
        else if (type == 3)
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());

            _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
        }
    }

    public void ListGoalDetails()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void RecordEvent()
    {
        ListGoalDetails();

        Console.Write("Which goal did you accomplish? ");
        int index = int.Parse(Console.ReadLine()) - 1;

        // Polymorphism happens here 
        int earned = _goals[index].RecordEvent();
        // Add earned points to total score
        _score += earned;

        Console.WriteLine($"Congratulations! You earned {earned} points!");
        Console.WriteLine($"You now have {_score} points.");
    }

    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            //Save score first 
            writer.WriteLine($"Score: {_score}");
            foreach (Goal goal in _goals)
            {
                // Each goal writes itself int its own format
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved successfully.");
    }


    public void LoadGoals()
    {
        Console.Write("Enter Filename: ");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        // Reads the entire file into array of lines
        string[] lines = File.ReadAllLines(filename);
        // Clear current goals
        _goals.Clear();

        foreach(string line in lines)
        {
            if (line.StartsWith("Score:"))
            {
                // split at ':' and take second part as score
                _score = int.Parse(line.Split(':')[1]);
            }
            else
            {
                // Split goal line into pieces
                string[] parts = line.Split('|');

                string type = parts[0];

                if (type == "SimpleGoal")
                {
                    SimpleGoal goal = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]));
                    if (bool.Parse(parts[4]))
                        // restore completion
                        goal.RecordEvent();
                    _goals.Add(goal);
                }
                else if (type == "EternalGoal")
                {
                    _goals.Add(new EternalGoal(parts[1], parts[3], int.Parse(parts[3])));
                }
                else if (type == "ChecklistGoal")
                {
                    ChecklistGoal goal = new ChecklistGoal(parts[1], parts[2],
                    int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]));

                    int completed = int.Parse(parts[6]);
                    for (int i = 0; i < completed; i++)
                    {
                        // Rebuild progress
                        goal.RecordEvent();
                    }
                    _goals.Add(goal);
                }
            }
        }
        Console.WriteLine("Goals loaded successfully.");
    }

}