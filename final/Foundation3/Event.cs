public abstract class Event
{
    
    private string _title;
    private string _description;
    private DateTime _dateTime;
    private Address _address;

    
    public Event(string title, string description, DateTime dateTime, Address address)
    {
        _title = title;
        _description = description;
        _dateTime = dateTime;
        _address = address;
    }

    public string GetTitle()
    {
        return _title;
    }

    public void SetTitle(string title)
    {
        _title = title;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public DateTime GetDateTime()
    {
        return _dateTime;
    }

    public void SetDateTime(DateTime dateTime)
    {
        _dateTime = dateTime;
    }

    public Address GetAddress()
    {
        return _address;
    }

    public void SetAddress(Address address)
    {
        _address = address;
    }

    public virtual string GetStandardDetails()
    {
        return $"Title: {_title}\n" +
               $"Description: {_description}\n" +
               $"Date: {_dateTime.ToShortDateString()}\n" +
               $"Time: {_dateTime.ToShortTimeString()}\n" +
               $"Address: {_address.GetFullAddress()}";
    }

    public abstract string GetFullDetails();

    public abstract string GetShortDescription();
}