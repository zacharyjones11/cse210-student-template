class Program
{
    static void Main(string[] args)
    {
        Address lectureAddress = new Address("123 Conference Way", "Springfield", "IL", "62701");
        Address receptionAddress = new Address("456 Celebration Blvd", "Chicago", "IL", "60601");
        Address outdoorAddress = new Address("789 Park Lane", "Riverside", "CA", "92501");

        Lecture techTalk = new Lecture(
            "Future of AI", 
            "A deep dive into artificial intelligence trends", 
            new DateTime(2024, 7, 15, 18, 30, 0), 
            lectureAddress, 
            "Dr. Emily Chen", 
            100
        );

        Reception charityGala = new Reception(
            "Annual Charity Gala", 
            "Fundraising event for local education initiatives", 
            new DateTime(2024, 8, 20, 19, 0, 0), 
            receptionAddress, 
            "rsvp@charityfoundation.org"
        );

        OutdoorGathering summerConcert = new OutdoorGathering(
            "Summer Music Festival", 
            "Featuring local bands and food trucks", 
            new DateTime(2024, 6, 22, 16, 0, 0), 
            outdoorAddress, 
            "Sunny, 75°F with light breeze"
        );

        Console.WriteLine("Lecture Event Details:");
        Console.WriteLine("\nStandard Details:");
        Console.WriteLine(techTalk.GetStandardDetails());
        Console.WriteLine("\nFull Details:");
        Console.WriteLine(techTalk.GetFullDetails());
        Console.WriteLine("\nShort Description:");
        Console.WriteLine(techTalk.GetShortDescription());

        Console.WriteLine("\n" + new string('-', 50) + "\n");

        Console.WriteLine("Reception Event Details:");
        Console.WriteLine("\nStandard Details:");
        Console.WriteLine(charityGala.GetStandardDetails());
        Console.WriteLine("\nFull Details:");
        Console.WriteLine(charityGala.GetFullDetails());
        Console.WriteLine("\nShort Description:");
        Console.WriteLine(charityGala.GetShortDescription());

        Console.WriteLine("\n" + new string('-', 50) + "\n");

        Console.WriteLine("Outdoor Gathering Event Details:");
        Console.WriteLine("\nStandard Details:");
        Console.WriteLine(summerConcert.GetStandardDetails());
        Console.WriteLine("\nFull Details:");
        Console.WriteLine(summerConcert.GetFullDetails());
        Console.WriteLine("\nShort Description:");
        Console.WriteLine(summerConcert.GetShortDescription());
    }
}