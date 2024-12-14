
public class OutdoorGathering : Event
{
    private string _weatherForecast;

    public OutdoorGathering(string title, string description, DateTime dateTime, Address address, 
                             string weatherForecast) 
        : base(title, description, dateTime, address)
    {
        _weatherForecast = weatherForecast;
    }

    public string GetWeatherForecast()
    {
        return _weatherForecast;
    }

    public void SetWeatherForecast(string weatherForecast)
    {
        _weatherForecast = weatherForecast;
    }

    public override string GetFullDetails()
    {
        return GetStandardDetails() + $"\n" +
               $"Event Type: Outdoor Gathering\n" +
               $"Weather Forecast: {_weatherForecast}";
    }

    public override string GetShortDescription()
    {
        return $"Outdoor Gathering - {GetTitle()} on {GetDateTime().ToShortDateString()}";
    }
}
