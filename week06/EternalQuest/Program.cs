using System;

class Program
{
    static void Main(string[] args)
    {
        /*
EXCEEDING CORE REQUIREMENTS


This Eternal Quest program exceeds the core requirements in the following ways:

1. Polymorphic Goal Handling
   - The GoalManager does not contain any conditional logic to determine
     how different goal types behave.
   - Instead, each derived class (SimpleGoal, EternalGoal, ChecklistGoal)
     overrides RecordEvent(), IsComplete(), and GetStringRepresentation().
   - This allows the program to dynamically execute the correct behavior
     at runtime using polymorphism.

2. Structured File Persistence System
   - Goals are saved in a structured text format that includes:
       - Goal type
       - Name
       - Description
       - Points
       - Completion state
       - Checklist progress (if applicable)
   - When loading, the program reconstructs each goal dynamically
     based on its type using inheritance.
   - This demonstrates custom object serialization and reconstruction.

3. Bonus Logic Automation
   - Checklist goals automatically award bonus points when the
     target number of completions is reached.
   - The system dynamically updates completion status and score.

4. Expandable Architecture
   - New goal types can be added without modifying the GoalManager.
   - This follows the Open/Closed Principle and demonstrates
     scalable object-oriented design.

5. Separation of Responsibilities
   - Goal classes handle goal logic.
   - GoalManager handles menu interaction and score tracking.
   - Program.cs only initializes and starts the system.
   - This demonstrates proper abstraction and encapsulation.

*/
        GoalManager manager = new GoalManager();
        manager.Start();
    }

}