public class EternalGoal : Goal
{
    private int _timesCompleted;

    public EternalGoal(string name, string description, int points) 
        : base(name, description, points)
    {
        _timesCompleted = 0;
    }

    public int TimesCompleted
    {
        get
        {
            return TimesCompleted;
        }
    }

    public override int RecordEvent()
    {
        _timesCompleted++;
        return _pointValue;
    }

    public override string GetDetailsString()
    {
        return $"[ ] {_name} ({_description}) - Completed {_timesCompleted} times";
    }
}