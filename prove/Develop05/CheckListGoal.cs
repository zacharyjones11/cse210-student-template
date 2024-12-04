public class ChecklistGoal : Goal
{
    private int _target;
    private int _current;
    private int _bonusPoints;

    public ChecklistGoal(string name, string description, int points, int target, int bonusPoints) 
        : base(name, description, points)
    {
        _target = target;
        _current = 0;
        _bonusPoints = bonusPoints;
    }
    

    public int Target
    {
        get
        {
            return _target;
        }
    }

    public int Current
    {
        get
        {
            return _current;
        }
    }

    public int BonusPoints
    {
        get
        {
            return _bonusPoints;
        }
    }

    public override int RecordEvent()
    {
        _current++;
        if (_current == _target)
        {
            _isComplete = true;
            return _pointValue + _bonusPoints;
        }
        return _pointValue;
    }

    public override string GetDetailsString()
    {
        return $"[{(_isComplete ? "X" : " ")}] {_name} ({_description}) - Completed {_current}/{_target} times";
    }
}