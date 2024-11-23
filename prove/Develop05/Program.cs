public class Program
{
    public static void Main()
    {
        GoalManager manager = new GoalManager();

        while (true)
        {
            DisplayMenu();
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateNewGoal(manager);
                    break;
                case "2":
                    RecordEvent(manager);
                    break;
                case "3":
                    manager.DisplayGoals();
                    break;
                case "4":
                    manager.SaveToFile("goals.txt");
                    Console.WriteLine("Goals saved!");
                    break;
                case "5":
                    manager.LoadFromFile("goals.txt");
                    Console.WriteLine("Goals loaded!");
                    break;
                case "6":
                    return;
            }
        }
    }

    private static void DisplayMenu()
    {
        Console.WriteLine("\n=== Goal Tracking System ===");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. Record Event");
        Console.WriteLine("3. Display Goals");
        Console.WriteLine("4. Save Goals");
        Console.WriteLine("5. Load Goals");
        Console.WriteLine("6. Exit");
        Console.Write("\nSelect an option: ");
    }

    private static void CreateNewGoal(GoalManager manager)
    {
        Console.WriteLine("\nGoal Types:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.WriteLine("4. Negative Goal");
        
        Console.Write("Select goal type: ");
        string type = Console.ReadLine();
        
        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        
        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();
        
        Console.Write("Enter base points: ");
        int points = int.Parse(Console.ReadLine());

        Goal goal;
        switch (type)
        {
            case "1":
                goal = new SimpleGoal(name, description, points);
                break;
            case "2":
                goal = new EternalGoal(name, description, points);
                break;
            case "3":
                Console.Write("Enter target count: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points: ");
                int bonus = int.Parse(Console.ReadLine());
                goal = new ChecklistGoal(name, description, points, target, bonus);
                break;
            case "4":
                Console.Write("Enter grace period (0 for none): ");
                int gracePeriod = int.Parse(Console.ReadLine());
                goal = new NegativeGoal(name, description, points, gracePeriod);
                break;
            default:
                Console.WriteLine("Invalid goal type!");
                return;
        }
        
        manager.AddGoal(goal);
        Console.WriteLine("Goal created successfully!");
    }

    private static void RecordEvent(GoalManager manager)
    {
        if (manager.GetGoalCount() == 0)
        {
            Console.WriteLine("No goals available to record!");
            return;
        }

        manager.DisplayGoals();
        Console.Write("\nEnter goal number to record: ");
        if (int.TryParse(Console.ReadLine(), out int goalNum) && goalNum > 0 && goalNum <= manager.GetGoalCount())
        {
            manager.RecordEvent(goalNum - 1);
            Console.WriteLine($"Event recorded! Current score: {manager.GetScore()}");
        }
        else
        {
            Console.WriteLine("Invalid goal number!");
        }
    }
}