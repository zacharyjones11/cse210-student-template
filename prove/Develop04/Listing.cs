
public class Listing : Activity
{
   public Listing() 
        : base("Listing Activity", 
               "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    private List<string> _startmessage = 
    [
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?",
    ];

    private List<string> _answers = new();

    public void Run()
    {
        DisplayStartingMessage();
        ShowSpinner(_duration);

        Random random = new Random();
        int index = random.Next(0, _startmessage.Count);
        string prompt = _startmessage[index];

        // Display prompt and preparation message
        Console.WriteLine("\nList as many responses as you can to the following prompt:");
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine("\nYou may begin in:");
        ShowCountDown(5);  // Give them 5 seconds to think

        Console.WriteLine("\nStart listing...");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            string input = Console.ReadLine();
            _answers.Add(input);

        }

        foreach (string i in _answers)
        {
            Console.WriteLine(i);
        }

        DisplayEndingMessage();


    }


}