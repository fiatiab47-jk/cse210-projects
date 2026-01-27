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

    // Saves entries to a file
    public void SaveToFile(string filename)
    {
        // Opens file for writing
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                // Stores entry data in one line (~) is used as a separator
                writer.WriteLine($"{entry._date}~{entry._promptText}~{entry._entryText}");
            }
        }
    }

    // Loads journal data form a file
    public void LoadFromFile(string filename)
    {
        // Prevents errors if file is missing
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not Found!");
            return;
        }
        // Removes old data before loading new ones
        _entries.Clear();
        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            // Splits stored text back into fields
            string[] parts = line.Split('~');
            
            // Creates new entry
            Entry entry = new Entry();
            entry._date = parts[0];
            entry._promptText = parts[1];
            entry._entryText = parts[2];

            _entries.Add(entry);
        }    
    }
}
