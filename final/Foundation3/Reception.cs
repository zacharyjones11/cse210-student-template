
public class Reception : Event
{
    private string _rsvpEmail;

    public Reception(string title, string description, DateTime dateTime, Address address, 
                     string rsvpEmail) 
        : base(title, description, dateTime, address)
    {
        _rsvpEmail = rsvpEmail;
    }

    public string GetRsvpEmail()
    {
        return _rsvpEmail;
    }

    public void SetRsvpEmail(string rsvpEmail)
    {
        _rsvpEmail = rsvpEmail;
    }

    public override string GetFullDetails()
    {
        return GetStandardDetails() + $"\n" +
               $"Event Type: Reception\n" +
               $"RSVP Email: {_rsvpEmail}";
    }

    public override string GetShortDescription()
    {
        return $"Reception - {GetTitle()} on {GetDateTime().ToShortDateString()}";
    }
}
