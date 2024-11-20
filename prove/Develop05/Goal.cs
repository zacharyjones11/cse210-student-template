public class Goal
{
    protected string _name;
    protected string _description;
    protected string _checkBox;
    protected int _pointValue;

    public Goal(string name, string _description, string checkBox, int _pointValue)
    {
        _name = name;
        _description = description;
        _checkBox = checkBox;
        _pointValue = pointValue;
    }

    public abstract Goal userGoal()
    {
        return 0;
    } 

}