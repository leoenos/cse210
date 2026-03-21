using System;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        Statistics stats = new Statistics();

        foreach (Entry entry in _entries)
        {
            entry.Display();
            Console.WriteLine($"Word count: {stats.WordCount(entry)}");
            Console.WriteLine();
        }
    }

    public void StringToFile(string file)
    {
        using (StreamWriter output = new StreamWriter(file))
            {
                foreach (Entry entry in _entries)
                {
                    output.WriteLine($"{entry._date} | {entry._promptText} | {entry._entryText}");
                }
            }
    }

    public void LoadFromFile(string file)
    {
        _entries.Clear();

        string[] lines = File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            Entry entry = new Entry();
            entry._date = parts[0];
            entry._promptText = parts[1];
            entry._entryText = parts[2];

            _entries.Add(entry);
        }
    }
}