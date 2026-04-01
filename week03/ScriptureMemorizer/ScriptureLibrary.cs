using System;

public class ScriptureLibrary
{
    private List<(Reference, string)> _scriptures;
    private Random _random = new Random();

    public ScriptureLibrary()
    {
        _scriptures = new List<(Reference, string)>();

        _scriptures.Add((new Reference("Scripture", 1, 10), "."));
    }

    public Scripture GetRandomScripture()
    {
        int index = _random.Next(_scriptures.Count);
        var script = _scriptures[index];
        return new Scripture(script.Item1, script.Item2);
    }
}