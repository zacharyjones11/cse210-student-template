public class Entry
{

    public string _dateNow;
    public string _prompt;
    public string _response;

    public static string GetRandomPrompt()
    {
        Random random = new();
        List<string> journalPrompt = ["Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"];
        int promptIndex = random.Next(journalPrompt.Count);
        string prompt = journalPrompt[promptIndex];
        return prompt;
    }

    public void AddEntry(Journal journal)
    {
        Entry entry = new();
        entry._prompt = Entry.GetRandomPrompt();
        Console.WriteLine(entry._prompt);
        entry._response = Console.ReadLine();
        DateTime currentDateTime = DateTime.Now;
        entry._dateNow = currentDateTime.ToShortDateString();
        
        journal._entries.Add(entry);
    }

}
       