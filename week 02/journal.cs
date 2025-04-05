using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> entries;

    public Journal()
    {
        entries = new List<Entry>();
    }

    public void AddEntry(string prompt, string response)
    {
        string date = DateTime.Now.ToString("yyyy-MM-dd");
        entries.Add(new Entry(prompt, response, date));
    }

    public void DisplayEntries()
    {
        foreach (var entry in entries)
        {
            Console.WriteLine($"Date: {entry.Date}\nPrompt: {entry.Prompt}\nResponse: {entry.Response}\n");
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in entries)
            {
                writer.WriteLine(entry.ToString());
            }
        }
        Console.WriteLine("Journal saved successfully!");
    }

    public void LoadFromFile(string filename)
    {
        if (File.Exists(filename))
        {
            entries.Clear();
            foreach (var line in File.ReadAllLines(filename))
            {
                var parts = line.Split('|');
                entries.Add(new Entry(parts[1], parts[2], parts[0]));
            }
            Console.WriteLine("Journal loaded successfully!");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}
