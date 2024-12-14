
public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string title, string description, DateTime dateTime, Address address, 
                   string speaker, int capacity) 
        : base(title, description, dateTime, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public string GetSpeaker()
    {
        return _speaker;
    }

    public void SetSpeaker(string speaker)
    {
        _speaker = speaker;
    }

    public int GetCapacity()
    {
        return _capacity;
    }

    public void SetCapacity(int capacity)
    {
        _capacity = capacity;
    }

    public override string GetFullDetails()
    {
        return GetStandardDetails() + $"\n" +
               $"Event Type: Lecture\n" +
               $"Speaker: {_speaker}\n" +
               $"Capacity: {_capacity}";
    }

    public override string GetShortDescription()
    {
        return $"Lecture - {GetTitle()} on {GetDateTime().ToShortDateString()}";
    }
}
