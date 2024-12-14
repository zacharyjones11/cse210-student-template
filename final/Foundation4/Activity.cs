public abstract class Activity
{
    private DateTime _date;
    private int _durationMinutes;

    public Activity(DateTime date, int durationMinutes)
    {
        _date = date;
        _durationMinutes = durationMinutes;
    }

    public DateTime GetDate() => _date;
    public int GetDurationMinutes() => _durationMinutes;

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{_date:dd MMM yyyy} {GetType().Name} ({_durationMinutes} min) - " +
               $"Distance {GetDistance():F1} miles, " +
               $"Speed {GetSpeed():F1} mph, " +
               $"Pace: {GetPace():F2} min per mile";
    }
}
