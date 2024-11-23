public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected bool _isComplete;
    protected int _pointValue;

    public Goal(string name, string description, int pointValue)
    {
        _name = name;
        _description = description;
        _isComplete = false;
        _pointValue = pointValue;
    }

public string Name 
{
    get 
    {
        return _name;
    }
}

public string Description 
{
    get 
    {
        return _description;
    }
}

public bool IsComplete
{
    get
    {
        return _isComplete;
    }
}

public int PointValue
{
    get
    {
        return _pointValue;
    }
}

public abstract int RecordEvent();
public abstract string GetDetailsString();

}