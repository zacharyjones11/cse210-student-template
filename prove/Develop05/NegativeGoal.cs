public class NegativeGoal : Goal
{
    private int _timesViolated;
    private int _gracePeriod;
    
    public NegativeGoal(string name, string description, int penaltyPoints, int gracePeriod = 0) 
        : base(name, description, penaltyPoints)
    {
        _timesViolated = 0;
        _gracePeriod = gracePeriod;
    }

    public int TimesViolated
    {
        get { return _timesViolated; }
    }

    public int RemainingGracePeriod
    {
        get 
        { 
            int remaining = _gracePeriod - _timesViolated;
            return remaining > 0 ? remaining : 0;
        }
    }

    public override int RecordEvent()
    {
        _timesViolated++;
        
        if (_timesViolated <= _gracePeriod)
        {
            Console.WriteLine($"Grace period violation {_timesViolated}/{_gracePeriod} - No points deducted");
            return 0;
        }
        else
        {
            Console.WriteLine($"Grace period exceeded - Deducting {_pointValue} points");
            return -_pointValue;
        }
    }

    public override string GetDetailsString()
    {
        string graceInfo = RemainingGracePeriod > 0 
            ? $" ({RemainingGracePeriod} grace violations remaining)"
            : " (No grace violations remaining)";
            
        return $"[!] {_name} ({_description}) - Violated {_timesViolated} times{graceInfo}";
    }
}