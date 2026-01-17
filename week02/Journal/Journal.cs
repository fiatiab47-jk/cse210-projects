using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    // Attributes
    public List<Entry> _entries = new List<Entry>();

    // Add an entry
    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    // Display all entries
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine($"{entry._date}~{entry._promptText}~{entry._entryText}");
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not Found!");
            return;
        }

        _entries.Clear();
        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split('~');
            
            Entry entry = new Entry();
            entry._date = parts[0];
            entry._promptText = parts[1];
            entry._entryText = parts[2];

            _entries.Add(entry);
        }    
    }
}
