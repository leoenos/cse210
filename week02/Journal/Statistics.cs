using System;

public class Statistics
{
    public int WordCount(Entry entry)
    {
        return entry._entryText.Split(' ').Length;
    }
    public int EntryCount(Journal journal)
    {
        return journal._entries.Count;
    }

    public int TotalWordCount(Journal journal)
    {
        int total = 0;
        foreach (Entry entry in journal._entries)
        {
            total += WordCount(entry);
        }
        return total;
    }
}