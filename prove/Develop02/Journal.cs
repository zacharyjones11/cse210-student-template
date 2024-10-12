using System;
using System.IO;

public class Journal
{
    public string _filePath;

    public List<Entry> _entries = new List<Entry>();

    public void LoadFromFile()
    {
        if (File.Exists(_filePath))
        {
            string[] lines = File.ReadAllLines(_filePath);
            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                Console.WriteLine($"Date: {parts[0]}");
                Console.WriteLine($"Prompt: {parts[1]}");
                Console.WriteLine($"Response: {parts[2]}\n");
            }
        }
        else
        {
            Console.WriteLine("No entries found.");
        }
    }
    public void SaveToFile()
    {
        Console.WriteLine("Enter File to save to: ");
        _filePath = Console.ReadLine();

    try
    {
        using (StreamWriter writer = new StreamWriter(_filePath, append: true))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine($"{entry._dateNow}|{entry._prompt}|{entry._response}");
            }
        }
        Console.WriteLine("Journal saved successfully.");
    }
    catch (IOException e)
        {
            Console.WriteLine($"An error occurred while saving the file: {e.Message}");
        }
    }

    public void DisplayJournal()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine($"{entry._dateNow} | {entry._prompt}");
            Console.WriteLine($"{entry._response}");
        }



    }
}

