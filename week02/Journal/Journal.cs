using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter writer = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
            }
        }
    }
   
    public void LoadFromFile(string filename)
    {
        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);

            foreach (string line in lines)
            {
                string[] seperatedParts = line.Split('|');
                if (seperatedParts.Length == 3)
                {
                    Entry entry = new Entry();
                    entry._date = seperatedParts[0];
                    entry._promptText = seperatedParts[1];
                    entry._entryText = seperatedParts[2];
                    _entries.Add(entry);
                }
            }

            Console.WriteLine("Journal Loaded Successfuly!\n");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}


