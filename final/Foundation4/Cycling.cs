public class Cycling : Activity
{
    private double _speed; // miles per hour

    public Cycling(DateTime date, int durationMinutes, double speed) 
        : base(date, durationMinutes)
    {
        _speed = speed;
    }

    public override double GetDistance() => (_speed * GetDurationMinutes()) / 60;

    public override double GetSpeed() => _speed;

    public override double GetPace() => 60 / _speed;
}
