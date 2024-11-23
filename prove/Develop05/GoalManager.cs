class GoalManager 
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void RecordEvent(int goalIndex)
    {
        if (goalIndex >= 0 && goalIndex < _goals.Count)
        {
            _score += _goals[goalIndex].RecordEvent();
        }
    }

    public void DisplayGoals()
    {
        Console.WriteLine("\nCurrent Goals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
        Console.WriteLine($"\nTotal Score: {_score} points");
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            // Save the score
            writer.WriteLine(_score);

            foreach (Goal goal in _goals)
            {
                if (goal is SimpleGoal)
                {
                    writer.WriteLine("SimpleGoal");
                    writer.WriteLine(goal.Name);
                    writer.WriteLine(goal.Description);
                    writer.WriteLine(goal.PointValue);
                    writer.WriteLine(goal.IsComplete);
                }
                else if (goal is EternalGoal eternal)
                {
                    writer.WriteLine("EternalGoal");
                    writer.WriteLine(goal.Name);
                    writer.WriteLine(goal.Description);
                    writer.WriteLine(goal.PointValue);
                    writer.WriteLine(eternal.TimesCompleted);
                }
                else if (goal is ChecklistGoal checklist)
                {
                    writer.WriteLine("ChecklistGoal");
                    writer.WriteLine(goal.Name);
                    writer.WriteLine(goal.Description);
                    writer.WriteLine(goal.PointValue);
                    writer.WriteLine(checklist.Target);
                    writer.WriteLine(checklist.Current);
                    writer.WriteLine(checklist.BonusPoints);
                    writer.WriteLine(goal.IsComplete);
                }
                else if (goal is NegativeGoal negative)
                {
                    writer.WriteLine("NegativeGoal");
                    writer.WriteLine(goal.Name);
                    writer.WriteLine(goal.Description);
                    writer.WriteLine(goal.PointValue);
                    writer.WriteLine(negative.TimesViolated);
                }
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("No save file found.");
            return;
        }

        _goals.Clear();
        
        using (StreamReader reader = new StreamReader(filename))
        {
            // Load the score
            _score = int.Parse(reader.ReadLine());

            while (!reader.EndOfStream)
            {
                string goalType = reader.ReadLine();
                
                switch (goalType)
                {
                    case "SimpleGoal":
                        string simpleName = reader.ReadLine();
                        string simpleDesc = reader.ReadLine();
                        int simplePoints = int.Parse(reader.ReadLine());
                        bool simpleComplete = bool.Parse(reader.ReadLine());
                        
                        SimpleGoal simple = new SimpleGoal(simpleName, simpleDesc, simplePoints);
                        if (simpleComplete)
                            simple.RecordEvent();
                        _goals.Add(simple);
                        break;

                    case "EternalGoal":
                        string eternalName = reader.ReadLine();
                        string eternalDesc = reader.ReadLine();
                        int eternalPoints = int.Parse(reader.ReadLine());
                        int timesCompleted = int.Parse(reader.ReadLine());
                        
                        EternalGoal eternal = new EternalGoal(eternalName, eternalDesc, eternalPoints);
                        for (int i = 0; i < timesCompleted; i++)
                            eternal.RecordEvent();
                        _goals.Add(eternal);
                        break;

                    case "ChecklistGoal":
                        string checklistName = reader.ReadLine();
                        string checklistDesc = reader.ReadLine();
                        int checklistPoints = int.Parse(reader.ReadLine());
                        int target = int.Parse(reader.ReadLine());
                        int current = int.Parse(reader.ReadLine());
                        int bonus = int.Parse(reader.ReadLine());
                        bool checklistComplete = bool.Parse(reader.ReadLine());
                        
                        ChecklistGoal checklist = new ChecklistGoal(checklistName, checklistDesc, checklistPoints, target, bonus);
                        for (int i = 0; i < current; i++)
                            checklist.RecordEvent();
                        _goals.Add(checklist);
                        break;
                    case "NegativeGoal":
                        string negativeName = reader.ReadLine();
                        string negativeDesc = reader.ReadLine();
                        int penaltyPoints = int.Parse(reader.ReadLine());
                        int timesViolated = int.Parse(reader.ReadLine());
                        
                        NegativeGoal negative = new NegativeGoal(negativeName, negativeDesc, penaltyPoints);
                        for (int i = 0; i < timesViolated; i++)
                            negative.RecordEvent();
                        _goals.Add(negative);
                        break;
                }
            }
        }
    }

    public int GetGoalCount()
    {
        return _goals.Count;
    }

    public int GetScore()
    {
        return _score;
    }
}