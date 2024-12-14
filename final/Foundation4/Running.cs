
public class Running : Activity
{

    private double _distance; // miles

    public Running(DateTime date, int durationMinutes, double distance) 
        : base(date, durationMinutes)
    {
        _distance = distance;
    }

    public override double GetDistance() => _distance;

    public override double GetSpeed() => (_distance / GetDurationMinutes()) * 60;

    public override double GetPace() => GetDurationMinutes() / _distance;
}
